﻿namespace Karaboss
{
    partial class frmPianoTraining
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPianoTraining));
            this.pnlScrollView = new System.Windows.Forms.Panel();
            this.vPianoRollControl1 = new Sanford.Multimedia.Midi.VPianoRoll.VPianoRollControl();
            this.pnlPiano = new System.Windows.Forms.Panel();
            this.pnlRedPianoSep = new System.Windows.Forms.Panel();
            this.pianoControl1 = new Sanford.Multimedia.Midi.UI.PianoControl();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnTempoMinus = new System.Windows.Forms.Button();
            this.lblTempoValue = new System.Windows.Forms.Label();
            this.btnTempoPlus = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.positionHScrollBar = new ColorSlider.ColorSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlScrollView.SuspendLayout();
            this.pnlPiano.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScrollView
            // 
            this.pnlScrollView.Controls.Add(this.vPianoRollControl1);
            resources.ApplyResources(this.pnlScrollView, "pnlScrollView");
            this.pnlScrollView.Name = "pnlScrollView";
            // 
            // vPianoRollControl1
            // 
            resources.ApplyResources(this.vPianoRollControl1, "vPianoRollControl1");
            this.vPianoRollControl1.HighNoteID = 108;
            this.vPianoRollControl1.LowNoteID = 23;
            this.vPianoRollControl1.Name = "vPianoRollControl1";
            this.vPianoRollControl1.OffsetY = 0;
            this.vPianoRollControl1.Resolution = 4;
            this.vPianoRollControl1.Sequence1 = null;
            this.vPianoRollControl1.TrackNum = -1;
            this.vPianoRollControl1.xScale = 0.1D;
            this.vPianoRollControl1.yScale = 0D;
            // 
            // pnlPiano
            // 
            this.pnlPiano.Controls.Add(this.pnlRedPianoSep);
            this.pnlPiano.Controls.Add(this.pianoControl1);
            resources.ApplyResources(this.pnlPiano, "pnlPiano");
            this.pnlPiano.Name = "pnlPiano";
            // 
            // pnlRedPianoSep
            // 
            this.pnlRedPianoSep.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.pnlRedPianoSep, "pnlRedPianoSep");
            this.pnlRedPianoSep.Name = "pnlRedPianoSep";
            // 
            // pianoControl1
            // 
            this.pianoControl1.HighNoteID = 108;
            resources.ApplyResources(this.pianoControl1, "pianoControl1");
            this.pianoControl1.LowNoteID = 23;
            this.pianoControl1.Name = "pianoControl1";
            this.pianoControl1.NoteOnColor = System.Drawing.Color.SkyBlue;
            this.pianoControl1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.pianoControl1.Scale = 20;
            this.pianoControl1.zoom = 1F;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(95)))));
            this.pnlTop.Controls.Add(this.pnlDisplay);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.lblTempo);
            this.pnlTop.Controls.Add(this.btnTempoMinus);
            this.pnlTop.Controls.Add(this.lblTempoValue);
            this.pnlTop.Controls.Add(this.btnTempoPlus);
            this.pnlTop.Controls.Add(this.BtnStop);
            this.pnlTop.Controls.Add(this.BtnPlay);
            this.pnlTop.Controls.Add(this.positionHScrollBar);
            resources.ApplyResources(this.pnlTop, "pnlTop");
            this.pnlTop.Name = "pnlTop";
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.Black;
            this.pnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDisplay.Controls.Add(this.lblElapsed);
            this.pnlDisplay.Controls.Add(this.lblPercent);
            this.pnlDisplay.Controls.Add(this.lblDuration);
            resources.ApplyResources(this.pnlDisplay, "pnlDisplay");
            this.pnlDisplay.Name = "pnlDisplay";
            // 
            // lblElapsed
            // 
            this.lblElapsed.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblElapsed, "lblElapsed");
            this.lblElapsed.ForeColor = System.Drawing.Color.White;
            this.lblElapsed.Name = "lblElapsed";
            // 
            // lblPercent
            // 
            resources.ApplyResources(this.lblPercent, "lblPercent");
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.ForeColor = System.Drawing.Color.White;
            this.lblPercent.Name = "lblPercent";
            // 
            // lblDuration
            // 
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblDuration, "lblDuration");
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Name = "lblDuration";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // lblTempo
            // 
            this.lblTempo.BackColor = System.Drawing.Color.Black;
            this.lblTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lblTempo, "lblTempo");
            this.lblTempo.Name = "lblTempo";
            // 
            // btnTempoMinus
            // 
            resources.ApplyResources(this.btnTempoMinus, "btnTempoMinus");
            this.btnTempoMinus.Name = "btnTempoMinus";
            this.btnTempoMinus.UseVisualStyleBackColor = true;
            this.btnTempoMinus.Click += new System.EventHandler(this.btnTempoMinus_Click);
            // 
            // lblTempoValue
            // 
            this.lblTempoValue.BackColor = System.Drawing.Color.Black;
            this.lblTempoValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTempoValue.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lblTempoValue, "lblTempoValue");
            this.lblTempoValue.Name = "lblTempoValue";
            // 
            // btnTempoPlus
            // 
            resources.ApplyResources(this.btnTempoPlus, "btnTempoPlus");
            this.btnTempoPlus.Name = "btnTempoPlus";
            this.btnTempoPlus.UseVisualStyleBackColor = true;
            this.btnTempoPlus.Click += new System.EventHandler(this.btnTempoPlus_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Image = global::Karaboss.Properties.Resources.Media_Controls_Stop_icon;
            resources.ApplyResources(this.BtnStop, "BtnStop");
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.TabStop = false;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Image = global::Karaboss.Properties.Resources.Media_Controls_Play_icon;
            resources.ApplyResources(this.BtnPlay, "BtnPlay");
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.TabStop = false;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // positionHScrollBar
            // 
            this.positionHScrollBar.BackColor = System.Drawing.Color.Transparent;
            this.positionHScrollBar.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.positionHScrollBar.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.positionHScrollBar.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.positionHScrollBar.ElapsedInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.positionHScrollBar.ElapsedPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(130)))), ((int)(((byte)(208)))));
            this.positionHScrollBar.ElapsedPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            resources.ApplyResources(this.positionHScrollBar, "positionHScrollBar");
            this.positionHScrollBar.ForeColor = System.Drawing.Color.White;
            this.positionHScrollBar.LargeChange = ((uint)(10u));
            this.positionHScrollBar.MouseWheelBarPartitions = 1;
            this.positionHScrollBar.Name = "positionHScrollBar";
            this.positionHScrollBar.ScaleDivisions = 5;
            this.positionHScrollBar.ScaleSubDivisions = 5;
            this.positionHScrollBar.ShowDivisionsText = true;
            this.positionHScrollBar.ShowSmallScale = false;
            this.positionHScrollBar.SmallChange = ((uint)(10u));
            this.positionHScrollBar.TabStop = false;
            this.positionHScrollBar.ThumbImage = global::Karaboss.Properties.Resources.BTN_Thumb_Blue;
            this.positionHScrollBar.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.positionHScrollBar.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(56)))), ((int)(((byte)(152)))));
            this.positionHScrollBar.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.positionHScrollBar.ThumbSize = new System.Drawing.Size(16, 16);
            this.positionHScrollBar.TickAdd = 0F;
            this.positionHScrollBar.TickColor = System.Drawing.Color.White;
            this.positionHScrollBar.TickDivide = 0F;
            this.positionHScrollBar.Value = 0;
            this.positionHScrollBar.ValueChanged += new System.EventHandler(this.positionHScrollBar_ValueChanged);
            this.positionHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.positionHScrollBar_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPianoTraining
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlScrollView);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlPiano);
            this.Name = "frmPianoTraining";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPianoTraining_FormClosing);
            this.Load += new System.EventHandler(this.frmPianoTraining_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPianoTraining_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPianoTraining_KeyUp);
            this.Resize += new System.EventHandler(this.frmPianoTraining_Resize);
            this.pnlScrollView.ResumeLayout(false);
            this.pnlPiano.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScrollView;
        private System.Windows.Forms.Panel pnlPiano;
        private System.Windows.Forms.Panel pnlTop;
        private Sanford.Multimedia.Midi.VPianoRoll.VPianoRollControl vPianoRollControl1;
        private Sanford.Multimedia.Midi.UI.PianoControl pianoControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPlay;
        private ColorSlider.ColorSlider positionHScrollBar;
        private System.Windows.Forms.Panel pnlRedPianoSep;
        private System.Windows.Forms.Button btnTempoMinus;
        private System.Windows.Forms.Label lblTempoValue;
        private System.Windows.Forms.Button btnTempoPlus;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblDuration;
    }
}