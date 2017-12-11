namespace BeamToBeamConnection
{
	partial class BeamToBeamConnection
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeamToBeamConnection));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonEndPlate144 = new System.Windows.Forms.Button();
			this.buttonShearPlateSimple146 = new System.Windows.Forms.Button();
			this.buttonClipAngle141 = new System.Windows.Forms.Button();
			this.buttonCreateBeams = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BeamToBeamConnection.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(51, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(172, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// buttonEndPlate144
			// 
			this.buttonEndPlate144.Location = new System.Drawing.Point(21, 220);
			this.buttonEndPlate144.Name = "buttonEndPlate144";
			this.buttonEndPlate144.Size = new System.Drawing.Size(228, 42);
			this.buttonEndPlate144.TabIndex = 3;
			this.buttonEndPlate144.Text = "End Plate (144)";
			this.buttonEndPlate144.UseVisualStyleBackColor = true;
			this.buttonEndPlate144.Click += new System.EventHandler(this.buttonEndPlate144_Click);
			// 
			// buttonShearPlateSimple146
			// 
			this.buttonShearPlateSimple146.Location = new System.Drawing.Point(21, 268);
			this.buttonShearPlateSimple146.Name = "buttonShearPlateSimple146";
			this.buttonShearPlateSimple146.Size = new System.Drawing.Size(228, 42);
			this.buttonShearPlateSimple146.TabIndex = 4;
			this.buttonShearPlateSimple146.Text = "Shear Plate Simple (146)";
			this.buttonShearPlateSimple146.UseVisualStyleBackColor = true;
			this.buttonShearPlateSimple146.Click += new System.EventHandler(this.buttonShearPlateSimple146_Click);
			// 
			// buttonClipAngle141
			// 
			this.buttonClipAngle141.Location = new System.Drawing.Point(21, 172);
			this.buttonClipAngle141.Name = "buttonClipAngle141";
			this.buttonClipAngle141.Size = new System.Drawing.Size(228, 42);
			this.buttonClipAngle141.TabIndex = 5;
			this.buttonClipAngle141.Text = "Clip Angle (141)";
			this.buttonClipAngle141.UseVisualStyleBackColor = true;
			this.buttonClipAngle141.Click += new System.EventHandler(this.buttonClipAngle141_Click);
			// 
			// buttonCreateBeams
			// 
			this.buttonCreateBeams.Location = new System.Drawing.Point(21, 102);
			this.buttonCreateBeams.Name = "buttonCreateBeams";
			this.buttonCreateBeams.Size = new System.Drawing.Size(228, 42);
			this.buttonCreateBeams.TabIndex = 6;
			this.buttonCreateBeams.Text = "Create Beams";
			this.buttonCreateBeams.UseVisualStyleBackColor = true;
			this.buttonCreateBeams.Click += new System.EventHandler(this.buttonCreateBeams_Click);
			// 
			// BeamToBeamConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 351);
			this.Controls.Add(this.buttonCreateBeams);
			this.Controls.Add(this.buttonClipAngle141);
			this.Controls.Add(this.buttonShearPlateSimple146);
			this.Controls.Add(this.buttonEndPlate144);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BeamToBeamConnection";
			this.Text = "Beam To Beam Connection";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonEndPlate144;
		private System.Windows.Forms.Button buttonShearPlateSimple146;
		private System.Windows.Forms.Button buttonClipAngle141;
		private System.Windows.Forms.Button buttonCreateBeams;
	}
}

