using System;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Point = Tekla.Structures.Geometry3d.Point;

namespace BeamToBeamConnection
{
	public partial class BeamToBeamConnection : Form
	{
		private readonly Model _model;
		private Beam _primaryBeam;
		private Beam _secondaryBeam;

		public BeamToBeamConnection()
		{
			_model = new Model();
			InitializeComponent();
		}

		private void buttonCreateBeams_Click(object sender, EventArgs e)
		{
			_primaryBeam = new Beam(new Point(5000, 0, 0), new Point(7000, 0, 0))
			{
				Name = "BEAM",
				Class = "3",
				Finish = "PAINT",
				Profile = new Profile() { ProfileString = "W16X36" },
				Material = new Material { MaterialString = "A36" }
			};

			_secondaryBeam = new Beam(new Point(6000, 0, 0), new Point(6000, 1000, 0))
			{
				Name = "BEAM",
				Class = "5",
				Finish = "PAINT",
				Profile = new Profile() { ProfileString = "W10X15" },
				Material = new Material { MaterialString = "A36" }
			};

			_primaryBeam.Insert();
			_secondaryBeam.Insert();

			_model.CommitChanges();
		}

		private void buttonClipAngle141_Click(object sender, EventArgs e)
		{
			if (_primaryBeam == null || _secondaryBeam == null) return;

			var connection = new Connection
			{
				Name = "Clip angle",
				Number = 141,
			};

			connection.LoadAttributesFromFile("standard");
			connection.UpVector = new Vector(0, 0, 1000);
			connection.PositionType = PositionTypeEnum.COLLISION_PLANE;

			InsertConnection(connection);
		}

		private void buttonEndPlate144_Click(object sender, EventArgs e)
		{
			if (_primaryBeam == null || _secondaryBeam == null) return;

			var connection = new Connection
			{
				Name = "End plate",
				Number = 144,
			};

			connection.LoadAttributesFromFile("standard");
			connection.UpVector = new Vector(0, 0, 1000);
			connection.PositionType = PositionTypeEnum.COLLISION_PLANE;

			InsertConnection(connection);
		}

		private void buttonShearPlateSimple146_Click(object sender, EventArgs e)
		{
			if (_primaryBeam == null || _secondaryBeam == null) return;

			var connection = new Connection
			{
				Name = "Shear plate simple",
				Number = 146,
			};

			connection.LoadAttributesFromFile("standard");
			connection.UpVector = new Vector(0, 0, 1000);
			connection.PositionType = PositionTypeEnum.COLLISION_PLANE;

			InsertConnection(connection);
		}

		private void InsertConnection(Connection connection)
		{
			connection.SetPrimaryObject(_primaryBeam);
			connection.SetSecondaryObject(_secondaryBeam);

			if (!connection.Insert())
			{
				Console.WriteLine("Connection insert failed");
				return;
			}

			_model.CommitChanges();
		}
	}
}
