namespace Gade6112
{
    partial class Form1
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
            this.lbl_GameScreen = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lb_UpdateScreen = new System.Windows.Forms.ListBox();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_Attack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PlayerStats = new System.Windows.Forms.Label();
            this.rtb_HitAlert = new System.Windows.Forms.RichTextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_GameScreen
            // 
            this.lbl_GameScreen.AutoSize = true;
            this.lbl_GameScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameScreen.Location = new System.Drawing.Point(25, 26);
            this.lbl_GameScreen.Name = "lbl_GameScreen";
            this.lbl_GameScreen.Size = new System.Drawing.Size(0, 20);
            this.lbl_GameScreen.TabIndex = 0;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(707, 394);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lb_UpdateScreen
            // 
            this.lb_UpdateScreen.FormattingEnabled = true;
            this.lb_UpdateScreen.Location = new System.Drawing.Point(448, 293);
            this.lb_UpdateScreen.Name = "lb_UpdateScreen";
            this.lb_UpdateScreen.Size = new System.Drawing.Size(334, 95);
            this.lb_UpdateScreen.TabIndex = 14;
            // 
            // btn_Up
            // 
            this.btn_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Up.Location = new System.Drawing.Point(644, 26);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(55, 37);
            this.btn_Up.TabIndex = 15;
            this.btn_Up.Text = "^";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Right.Location = new System.Drawing.Point(714, 60);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(55, 37);
            this.btn_Right.TabIndex = 16;
            this.btn_Right.Text = ">";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Down.Location = new System.Drawing.Point(644, 98);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(55, 37);
            this.btn_Down.TabIndex = 17;
            this.btn_Down.Text = "v";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_left
            // 
            this.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left.Location = new System.Drawing.Point(572, 60);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(55, 37);
            this.btn_left.TabIndex = 18;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_Attack
            // 
            this.btn_Attack.Location = new System.Drawing.Point(633, 69);
            this.btn_Attack.Name = "btn_Attack";
            this.btn_Attack.Size = new System.Drawing.Size(75, 23);
            this.btn_Attack.TabIndex = 19;
            this.btn_Attack.Text = "Attack!";
            this.btn_Attack.UseVisualStyleBackColor = true;
            this.btn_Attack.Click += new System.EventHandler(this.btn_Attack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Objects in Range:";
            // 
            // lbl_PlayerStats
            // 
            this.lbl_PlayerStats.AutoSize = true;
            this.lbl_PlayerStats.Location = new System.Drawing.Point(445, 146);
            this.lbl_PlayerStats.Name = "lbl_PlayerStats";
            this.lbl_PlayerStats.Size = new System.Drawing.Size(66, 13);
            this.lbl_PlayerStats.TabIndex = 22;
            this.lbl_PlayerStats.Text = "Player Stats:";
            // 
            // rtb_HitAlert
            // 
            this.rtb_HitAlert.Location = new System.Drawing.Point(448, 395);
            this.rtb_HitAlert.Name = "rtb_HitAlert";
            this.rtb_HitAlert.Size = new System.Drawing.Size(158, 22);
            this.rtb_HitAlert.TabIndex = 23;
            this.rtb_HitAlert.Text = "";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(624, 239);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 24;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(713, 239);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 25;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.rtb_HitAlert);
            this.Controls.Add(this.lbl_PlayerStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Attack);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.lb_UpdateScreen);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_GameScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GameScreen;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ListBox lb_UpdateScreen;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_Attack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PlayerStats;
        private System.Windows.Forms.RichTextBox rtb_HitAlert;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Load;
    }
}

