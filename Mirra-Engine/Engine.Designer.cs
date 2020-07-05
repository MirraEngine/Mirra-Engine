namespace Mirra_Engine
{
    partial class Engine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engine));
            this.Info_Bar = new MetroFramework.Controls.MetroPanel();
            this.Time_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Console_Warning_Label = new System.Windows.Forms.Label();
            this.Saved_Progress_Label = new System.Windows.Forms.Label();
            this.Engine_StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Heirarchy_Panel = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Hirearchy_Tab = new MetroFramework.Controls.MetroTabPage();
            this.Objects_Tab = new MetroFramework.Controls.MetroTabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.Inspector_Panel = new MetroFramework.Controls.MetroPanel();
            this.Inspector_Display_Panel = new MetroFramework.Controls.MetroPanel();
            this.Play_Btn = new System.Windows.Forms.Button();
            this.Console_Panel = new MetroFramework.Controls.MetroPanel();
            this.Console_Display_Panel = new MetroFramework.Controls.MetroPanel();
            this.Stop_Btn = new System.Windows.Forms.Button();
            this.scene_view = new OpenTK.GLControl();
            this.Controls_Panel = new MetroFramework.Controls.MetroPanel();
            this.Control_Inspector_Btn = new System.Windows.Forms.Button();
            this.Control_Heirarchy_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Docker_Bottom = new MetroFramework.Controls.MetroPanel();
            this.Control_Console_Btn = new System.Windows.Forms.Button();
            this.Info_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Engine_StyleManager)).BeginInit();
            this.Heirarchy_Panel.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.Objects_Tab.SuspendLayout();
            this.Inspector_Panel.SuspendLayout();
            this.Console_Panel.SuspendLayout();
            this.Controls_Panel.SuspendLayout();
            this.Docker_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Info_Bar
            // 
            this.Info_Bar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Info_Bar.Controls.Add(this.Time_Label);
            this.Info_Bar.Controls.Add(this.Username_Label);
            this.Info_Bar.Controls.Add(this.Console_Warning_Label);
            this.Info_Bar.Controls.Add(this.Saved_Progress_Label);
            this.Info_Bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Info_Bar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Info_Bar.HorizontalScrollbarBarColor = true;
            this.Info_Bar.HorizontalScrollbarHighlightOnWheel = false;
            this.Info_Bar.HorizontalScrollbarSize = 10;
            this.Info_Bar.Location = new System.Drawing.Point(0, 1056);
            this.Info_Bar.Name = "Info_Bar";
            this.Info_Bar.Padding = new System.Windows.Forms.Padding(2);
            this.Info_Bar.Size = new System.Drawing.Size(1920, 24);
            this.Info_Bar.Style = MetroFramework.MetroColorStyle.Black;
            this.Info_Bar.TabIndex = 8;
            this.Info_Bar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Info_Bar.UseCustomBackColor = true;
            this.Info_Bar.VerticalScrollbarBarColor = true;
            this.Info_Bar.VerticalScrollbarHighlightOnWheel = false;
            this.Info_Bar.VerticalScrollbarSize = 10;
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.ForeColor = System.Drawing.Color.Silver;
            this.Time_Label.Location = new System.Drawing.Point(117, 5);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(123, 13);
            this.Time_Label.TabIndex = 5;
            this.Time_Label.Text = "6/26/2021  4:48 PM";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Label.ForeColor = System.Drawing.Color.Silver;
            this.Username_Label.Location = new System.Drawing.Point(10, 5);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(93, 13);
            this.Username_Label.TabIndex = 4;
            this.Username_Label.Text = "XxSadPandaxX";
            // 
            // Console_Warning_Label
            // 
            this.Console_Warning_Label.AutoSize = true;
            this.Console_Warning_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console_Warning_Label.ForeColor = System.Drawing.Color.Silver;
            this.Console_Warning_Label.Location = new System.Drawing.Point(329, 5);
            this.Console_Warning_Label.Name = "Console_Warning_Label";
            this.Console_Warning_Label.Size = new System.Drawing.Size(509, 13);
            this.Console_Warning_Label.TabIndex = 3;
            this.Console_Warning_Label.Text = "### WARNING ### LINE 46: 30 --> ThisVariable is Unused. Remove it UNUSED_VARS\r\n";
            // 
            // Saved_Progress_Label
            // 
            this.Saved_Progress_Label.AutoSize = true;
            this.Saved_Progress_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Saved_Progress_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saved_Progress_Label.ForeColor = System.Drawing.Color.Lime;
            this.Saved_Progress_Label.Location = new System.Drawing.Point(1824, 2);
            this.Saved_Progress_Label.Name = "Saved_Progress_Label";
            this.Saved_Progress_Label.Padding = new System.Windows.Forms.Padding(2);
            this.Saved_Progress_Label.Size = new System.Drawing.Size(94, 17);
            this.Saved_Progress_Label.TabIndex = 2;
            this.Saved_Progress_Label.Text = "Saving Project";
            // 
            // Engine_StyleManager
            // 
            this.Engine_StyleManager.Owner = this;
            this.Engine_StyleManager.Style = MetroFramework.MetroColorStyle.Black;
            // 
            // Heirarchy_Panel
            // 
            this.Heirarchy_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Heirarchy_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Heirarchy_Panel.Controls.Add(this.metroTabControl1);
            this.Heirarchy_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Heirarchy_Panel.HorizontalScrollbarBarColor = true;
            this.Heirarchy_Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Heirarchy_Panel.HorizontalScrollbarSize = 10;
            this.Heirarchy_Panel.Location = new System.Drawing.Point(0, 92);
            this.Heirarchy_Panel.Name = "Heirarchy_Panel";
            this.Heirarchy_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.Heirarchy_Panel.Size = new System.Drawing.Size(320, 964);
            this.Heirarchy_Panel.Style = MetroFramework.MetroColorStyle.Black;
            this.Heirarchy_Panel.TabIndex = 10;
            this.Heirarchy_Panel.VerticalScrollbarBarColor = true;
            this.Heirarchy_Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Heirarchy_Panel.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Hirearchy_Tab);
            this.metroTabControl1.Controls.Add(this.Objects_Tab);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(10, 10);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(298, 942);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Hirearchy_Tab
            // 
            this.Hirearchy_Tab.HorizontalScrollbar = true;
            this.Hirearchy_Tab.HorizontalScrollbarBarColor = true;
            this.Hirearchy_Tab.HorizontalScrollbarHighlightOnWheel = false;
            this.Hirearchy_Tab.HorizontalScrollbarSize = 10;
            this.Hirearchy_Tab.Location = new System.Drawing.Point(4, 35);
            this.Hirearchy_Tab.Name = "Hirearchy_Tab";
            this.Hirearchy_Tab.Size = new System.Drawing.Size(290, 903);
            this.Hirearchy_Tab.TabIndex = 0;
            this.Hirearchy_Tab.Text = "Scene";
            this.Hirearchy_Tab.VerticalScrollbar = true;
            this.Hirearchy_Tab.VerticalScrollbarBarColor = true;
            this.Hirearchy_Tab.VerticalScrollbarHighlightOnWheel = false;
            this.Hirearchy_Tab.VerticalScrollbarSize = 10;
            // 
            // Objects_Tab
            // 
            this.Objects_Tab.Controls.Add(this.button2);
            this.Objects_Tab.HorizontalScrollbarBarColor = true;
            this.Objects_Tab.HorizontalScrollbarHighlightOnWheel = false;
            this.Objects_Tab.HorizontalScrollbarSize = 10;
            this.Objects_Tab.Location = new System.Drawing.Point(4, 38);
            this.Objects_Tab.Name = "Objects_Tab";
            this.Objects_Tab.Padding = new System.Windows.Forms.Padding(20);
            this.Objects_Tab.Size = new System.Drawing.Size(290, 900);
            this.Objects_Tab.TabIndex = 1;
            this.Objects_Tab.Text = "New Object";
            this.Objects_Tab.VerticalScrollbarBarColor = true;
            this.Objects_Tab.VerticalScrollbarHighlightOnWheel = false;
            this.Objects_Tab.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(20, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Empty GameObject";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Inspector_Panel
            // 
            this.Inspector_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Inspector_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Inspector_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inspector_Panel.Controls.Add(this.Inspector_Display_Panel);
            this.Inspector_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Inspector_Panel.HorizontalScrollbarBarColor = true;
            this.Inspector_Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Inspector_Panel.HorizontalScrollbarSize = 10;
            this.Inspector_Panel.Location = new System.Drawing.Point(1600, 92);
            this.Inspector_Panel.Name = "Inspector_Panel";
            this.Inspector_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.Inspector_Panel.Size = new System.Drawing.Size(320, 964);
            this.Inspector_Panel.Style = MetroFramework.MetroColorStyle.Black;
            this.Inspector_Panel.TabIndex = 11;
            this.Inspector_Panel.VerticalScrollbarBarColor = true;
            this.Inspector_Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Inspector_Panel.VerticalScrollbarSize = 10;
            // 
            // Inspector_Display_Panel
            // 
            this.Inspector_Display_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Inspector_Display_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inspector_Display_Panel.HorizontalScrollbarBarColor = true;
            this.Inspector_Display_Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Inspector_Display_Panel.HorizontalScrollbarSize = 10;
            this.Inspector_Display_Panel.Location = new System.Drawing.Point(10, 10);
            this.Inspector_Display_Panel.Name = "Inspector_Display_Panel";
            this.Inspector_Display_Panel.Size = new System.Drawing.Size(298, 722);
            this.Inspector_Display_Panel.Style = MetroFramework.MetroColorStyle.Black;
            this.Inspector_Display_Panel.TabIndex = 4;
            this.Inspector_Display_Panel.UseCustomBackColor = true;
            this.Inspector_Display_Panel.VerticalScrollbarBarColor = true;
            this.Inspector_Display_Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Inspector_Display_Panel.VerticalScrollbarSize = 10;
            // 
            // Play_Btn
            // 
            this.Play_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Play_Btn.FlatAppearance.BorderSize = 0;
            this.Play_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Play_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.Play_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play_Btn.ForeColor = System.Drawing.Color.LightGray;
            this.Play_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Play_Btn.Image")));
            this.Play_Btn.Location = new System.Drawing.Point(883, 1);
            this.Play_Btn.Name = "Play_Btn";
            this.Play_Btn.Size = new System.Drawing.Size(45, 28);
            this.Play_Btn.TabIndex = 12;
            this.Play_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Play_Btn.UseVisualStyleBackColor = false;
            // 
            // Console_Panel
            // 
            this.Console_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Console_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Console_Panel.Controls.Add(this.Console_Display_Panel);
            this.Console_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Console_Panel.HorizontalScrollbarBarColor = true;
            this.Console_Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Console_Panel.HorizontalScrollbarSize = 10;
            this.Console_Panel.Location = new System.Drawing.Point(320, 824);
            this.Console_Panel.Name = "Console_Panel";
            this.Console_Panel.Padding = new System.Windows.Forms.Padding(10);
            this.Console_Panel.Size = new System.Drawing.Size(1280, 200);
            this.Console_Panel.TabIndex = 13;
            this.Console_Panel.VerticalScrollbarBarColor = true;
            this.Console_Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Console_Panel.VerticalScrollbarSize = 10;
            // 
            // Console_Display_Panel
            // 
            this.Console_Display_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Console_Display_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Console_Display_Panel.HorizontalScrollbarBarColor = true;
            this.Console_Display_Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Console_Display_Panel.HorizontalScrollbarSize = 10;
            this.Console_Display_Panel.Location = new System.Drawing.Point(10, 10);
            this.Console_Display_Panel.Name = "Console_Display_Panel";
            this.Console_Display_Panel.Size = new System.Drawing.Size(1258, 183);
            this.Console_Display_Panel.Style = MetroFramework.MetroColorStyle.Black;
            this.Console_Display_Panel.TabIndex = 4;
            this.Console_Display_Panel.UseCustomBackColor = true;
            this.Console_Display_Panel.VerticalScrollbarBarColor = true;
            this.Console_Display_Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Console_Display_Panel.VerticalScrollbarSize = 10;
            // 
            // Stop_Btn
            // 
            this.Stop_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Stop_Btn.FlatAppearance.BorderSize = 0;
            this.Stop_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Stop_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.Stop_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_Btn.ForeColor = System.Drawing.Color.LightGray;
            this.Stop_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Stop_Btn.Image")));
            this.Stop_Btn.Location = new System.Drawing.Point(934, 1);
            this.Stop_Btn.Name = "Stop_Btn";
            this.Stop_Btn.Size = new System.Drawing.Size(47, 28);
            this.Stop_Btn.TabIndex = 14;
            this.Stop_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Stop_Btn.UseVisualStyleBackColor = false;
            // 
            // scene_view
            // 
            this.scene_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.scene_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scene_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scene_view.Location = new System.Drawing.Point(320, 92);
            this.scene_view.Name = "scene_view";
            this.scene_view.Size = new System.Drawing.Size(1280, 732);
            this.scene_view.TabIndex = 15;
            this.scene_view.VSync = false;
            this.scene_view.Load += new System.EventHandler(this.SceneView_Init);
            this.scene_view.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SceneView_MouseScroll);
            this.scene_view.Paint += new System.Windows.Forms.PaintEventHandler(this.SceneView_Render);
            this.scene_view.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SceneView_OnKeyDown);
            this.scene_view.MouseEnter += new System.EventHandler(this.SceneView_MouseEnter);
            this.scene_view.MouseLeave += new System.EventHandler(this.SceneView_MouseLeave);
            this.scene_view.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SceneView_MouseMove);
            this.scene_view.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SceneView_MouseUp);
            this.scene_view.Resize += new System.EventHandler(this.SceneView_OnResize);
            // 
            // Controls_Panel
            // 
            this.Controls_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls_Panel.Controls.Add(this.Control_Inspector_Btn);
            this.Controls_Panel.Controls.Add(this.Control_Heirarchy_Btn);
            this.Controls_Panel.Controls.Add(this.button1);
            this.Controls_Panel.Controls.Add(this.Stop_Btn);
            this.Controls_Panel.Controls.Add(this.Play_Btn);
            this.Controls_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Controls_Panel.HorizontalScrollbarBarColor = true;
            this.Controls_Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Controls_Panel.HorizontalScrollbarSize = 10;
            this.Controls_Panel.Location = new System.Drawing.Point(0, 60);
            this.Controls_Panel.Name = "Controls_Panel";
            this.Controls_Panel.Size = new System.Drawing.Size(1920, 32);
            this.Controls_Panel.TabIndex = 16;
            this.Controls_Panel.VerticalScrollbarBarColor = true;
            this.Controls_Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Controls_Panel.VerticalScrollbarSize = 10;
            // 
            // Control_Inspector_Btn
            // 
            this.Control_Inspector_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Control_Inspector_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Control_Inspector_Btn.FlatAppearance.BorderSize = 0;
            this.Control_Inspector_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Control_Inspector_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_Inspector_Btn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Control_Inspector_Btn.Location = new System.Drawing.Point(1843, 0);
            this.Control_Inspector_Btn.Name = "Control_Inspector_Btn";
            this.Control_Inspector_Btn.Size = new System.Drawing.Size(75, 30);
            this.Control_Inspector_Btn.TabIndex = 23;
            this.Control_Inspector_Btn.Text = "Inspector";
            this.Control_Inspector_Btn.UseVisualStyleBackColor = false;
            this.Control_Inspector_Btn.Click += new System.EventHandler(this.Control_Inspector_Btn_Click);
            // 
            // Control_Heirarchy_Btn
            // 
            this.Control_Heirarchy_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Control_Heirarchy_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Control_Heirarchy_Btn.FlatAppearance.BorderSize = 0;
            this.Control_Heirarchy_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Control_Heirarchy_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_Heirarchy_Btn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Control_Heirarchy_Btn.Location = new System.Drawing.Point(0, 0);
            this.Control_Heirarchy_Btn.Name = "Control_Heirarchy_Btn";
            this.Control_Heirarchy_Btn.Size = new System.Drawing.Size(75, 30);
            this.Control_Heirarchy_Btn.TabIndex = 22;
            this.Control_Heirarchy_Btn.Text = "Heirarchy";
            this.Control_Heirarchy_Btn.UseVisualStyleBackColor = false;
            this.Control_Heirarchy_Btn.Click += new System.EventHandler(this.Control_Heirarchy_Btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(987, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 28);
            this.button1.TabIndex = 15;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Docker_Bottom
            // 
            this.Docker_Bottom.Controls.Add(this.Control_Console_Btn);
            this.Docker_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Docker_Bottom.HorizontalScrollbarBarColor = true;
            this.Docker_Bottom.HorizontalScrollbarHighlightOnWheel = false;
            this.Docker_Bottom.HorizontalScrollbarSize = 10;
            this.Docker_Bottom.Location = new System.Drawing.Point(320, 1024);
            this.Docker_Bottom.Name = "Docker_Bottom";
            this.Docker_Bottom.Padding = new System.Windows.Forms.Padding(2);
            this.Docker_Bottom.Size = new System.Drawing.Size(1280, 32);
            this.Docker_Bottom.TabIndex = 19;
            this.Docker_Bottom.VerticalScrollbarBarColor = true;
            this.Docker_Bottom.VerticalScrollbarHighlightOnWheel = false;
            this.Docker_Bottom.VerticalScrollbarSize = 10;
            // 
            // Control_Console_Btn
            // 
            this.Control_Console_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Control_Console_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Control_Console_Btn.FlatAppearance.BorderSize = 0;
            this.Control_Console_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Control_Console_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_Console_Btn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Control_Console_Btn.Location = new System.Drawing.Point(2, 2);
            this.Control_Console_Btn.Name = "Control_Console_Btn";
            this.Control_Console_Btn.Size = new System.Drawing.Size(75, 28);
            this.Control_Console_Btn.TabIndex = 21;
            this.Control_Console_Btn.Text = "Console";
            this.Control_Console_Btn.UseVisualStyleBackColor = false;
            this.Control_Console_Btn.Click += new System.EventHandler(this.Control_Console_Btn_Click);
            // 
            // Engine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.scene_view);
            this.Controls.Add(this.Console_Panel);
            this.Controls.Add(this.Docker_Bottom);
            this.Controls.Add(this.Inspector_Panel);
            this.Controls.Add(this.Heirarchy_Panel);
            this.Controls.Add(this.Controls_Panel);
            this.Controls.Add(this.Info_Bar);
            this.Name = "Engine";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Mirra Engine";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SceneView_Init);
            this.Info_Bar.ResumeLayout(false);
            this.Info_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Engine_StyleManager)).EndInit();
            this.Heirarchy_Panel.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.Objects_Tab.ResumeLayout(false);
            this.Inspector_Panel.ResumeLayout(false);
            this.Console_Panel.ResumeLayout(false);
            this.Controls_Panel.ResumeLayout(false);
            this.Docker_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel Info_Bar;
        private MetroFramework.Components.MetroStyleManager Engine_StyleManager;
        private MetroFramework.Controls.MetroPanel Heirarchy_Panel;
        private MetroFramework.Controls.MetroPanel Inspector_Panel;
        private System.Windows.Forms.Button Play_Btn;
        private MetroFramework.Controls.MetroPanel Console_Panel;
        private MetroFramework.Controls.MetroPanel Console_Display_Panel;
        private System.Windows.Forms.Label Console_Warning_Label;
        private System.Windows.Forms.Label Saved_Progress_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.Button Stop_Btn;
        private MetroFramework.Controls.MetroPanel Controls_Panel;
        private OpenTK.GLControl scene_view;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroPanel Inspector_Display_Panel;
        private MetroFramework.Controls.MetroPanel Docker_Bottom;
        private System.Windows.Forms.Button Control_Console_Btn;
        private System.Windows.Forms.Button Control_Inspector_Btn;
        private System.Windows.Forms.Button Control_Heirarchy_Btn;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Hirearchy_Tab;
        private MetroFramework.Controls.MetroTabPage Objects_Tab;
        private System.Windows.Forms.Button button2;
    }
}

