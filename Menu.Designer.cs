using System;
using System.Windows.Forms;
using System.Threading;
using ROS;
using Whynot;

namespace RosPublicCheat
{
    partial class menu
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
            this.ESP_PLAYER = new System.Windows.Forms.Label();
            this.ESP_ITEM = new System.Windows.Forms.Label();
            this.ESP_PLAYER_DISTANCE = new System.Windows.Forms.Label();
            this.ESP_SUPPLY = new System.Windows.Forms.Label();
            this.ESP_HEALTH = new System.Windows.Forms.Label();
            this.ESP_ROBOT = new System.Windows.Forms.Label();
            this.ESP_ITEM_DISTANCE = new System.Windows.Forms.Label();
            this.ESP_LINES = new System.Windows.Forms.Label();
            this.ESP_BOT_HEALTH = new System.Windows.Forms.Label();
            this.PLAYER_ESP_BUTTON = new System.Windows.Forms.Button();
            this.ESP_LINES_BUTTON = new System.Windows.Forms.Button();
            this.ESP_SUPPLY_BOX_BUTTON = new System.Windows.Forms.Button();
            this.ESP_ITEM_DISTANCE_BUTTON = new System.Windows.Forms.Button();
            this.ESP_ITEM_BUTTON = new System.Windows.Forms.Button();
            this.ESP_BOT_HEALTH_BUTTON = new System.Windows.Forms.Button();
            this.ESP_BOT_BUTTON = new System.Windows.Forms.Button();
            this.ESP_PLAYER_DISTANCE_BUTTON = new System.Windows.Forms.Button();
            this.ESP_HEALTH_BUTTON = new System.Windows.Forms.Button();
            this.ESP_VEHICLE_BUTTON = new System.Windows.Forms.Button();
            this.ESP_VEHICLE_DISTANCE_BUTTON = new System.Windows.Forms.Button();
            this.VEHICLE_DISTANCE = new System.Windows.Forms.Label();
            this.ESP_VEHICLE = new System.Windows.Forms.Label();
            this.ESP_PLANE_BUTTON = new System.Windows.Forms.Button();
            this.PLANE_ESP = new System.Windows.Forms.Label();
            this.TABS = new System.Windows.Forms.TabControl();
            this.ESP_TAB = new System.Windows.Forms.TabPage();
            this.box = new System.Windows.Forms.Label();
            this.BOX_BUTTON = new System.Windows.Forms.Button();
            this.AIMBOT_TAB = new System.Windows.Forms.TabPage();
            this.AIMBOT_BUTTON = new System.Windows.Forms.Button();
            this.AIMBOT = new System.Windows.Forms.Label();
            this.SHOW_FOV_BUTTON = new System.Windows.Forms.Button();
            this.FOV_SHOW = new System.Windows.Forms.Label();
            this.SCOPE_BUTTON = new System.Windows.Forms.Button();
            this.scope = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HOLDKEY_BUTTON = new System.Windows.Forms.Button();
            this.SMARTAIM = new System.Windows.Forms.Label();
            this.SMARTAIM_BUTTON = new System.Windows.Forms.Button();
            this.FOV_BAR = new System.Windows.Forms.TrackBar();
            this.FOV_LABEL = new System.Windows.Forms.Label();
            this.RANGE_AIMBOT = new System.Windows.Forms.TrackBar();
            this.AIMBOT_DISTANCE = new System.Windows.Forms.Label();
            this.NOCLIP_TAB = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.WALLKILL_BUTTON = new System.Windows.Forms.Button();
            this.NOCLLIP_CONTROLS = new System.Windows.Forms.Label();
            this.NOCLIP = new System.Windows.Forms.Label();
            this.NOCLIP_BUTTON = new System.Windows.Forms.Button();
            this.MISC_TAB = new System.Windows.Forms.TabPage();
            this.NoGrassText = new System.Windows.Forms.Label();
            this.NOGRASS_BUTTON = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.credit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GOLD_ITEM_ESP_BUTTON = new System.Windows.Forms.Button();
            this.TABS.SuspendLayout();
            this.ESP_TAB.SuspendLayout();
            this.AIMBOT_TAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOV_BAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RANGE_AIMBOT)).BeginInit();
            this.NOCLIP_TAB.SuspendLayout();
            this.MISC_TAB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ESP_PLAYER
            // 
            this.ESP_PLAYER.AutoSize = true;
            this.ESP_PLAYER.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_PLAYER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_PLAYER.Location = new System.Drawing.Point(20, 22);
            this.ESP_PLAYER.Name = "ESP_PLAYER";
            this.ESP_PLAYER.Size = new System.Drawing.Size(103, 32);
            this.ESP_PLAYER.TabIndex = 0;
            this.ESP_PLAYER.Text = "PLAYER";
            // 
            // ESP_ITEM
            // 
            this.ESP_ITEM.AutoSize = true;
            this.ESP_ITEM.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_ITEM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_ITEM.Location = new System.Drawing.Point(425, 12);
            this.ESP_ITEM.Name = "ESP_ITEM";
            this.ESP_ITEM.Size = new System.Drawing.Size(72, 32);
            this.ESP_ITEM.TabIndex = 1;
            this.ESP_ITEM.Text = "ITEM";
            // 
            // ESP_PLAYER_DISTANCE
            // 
            this.ESP_PLAYER_DISTANCE.AutoSize = true;
            this.ESP_PLAYER_DISTANCE.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_PLAYER_DISTANCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_PLAYER_DISTANCE.Location = new System.Drawing.Point(20, 146);
            this.ESP_PLAYER_DISTANCE.Name = "ESP_PLAYER_DISTANCE";
            this.ESP_PLAYER_DISTANCE.Size = new System.Drawing.Size(132, 32);
            this.ESP_PLAYER_DISTANCE.TabIndex = 3;
            this.ESP_PLAYER_DISTANCE.Text = "DISTANCE";
            // 
            // ESP_SUPPLY
            // 
            this.ESP_SUPPLY.AutoSize = true;
            this.ESP_SUPPLY.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_SUPPLY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_SUPPLY.Location = new System.Drawing.Point(425, 217);
            this.ESP_SUPPLY.Name = "ESP_SUPPLY";
            this.ESP_SUPPLY.Size = new System.Drawing.Size(162, 32);
            this.ESP_SUPPLY.TabIndex = 4;
            this.ESP_SUPPLY.Text = "SUPPLY BOX";
            // 
            // ESP_HEALTH
            // 
            this.ESP_HEALTH.AutoSize = true;
            this.ESP_HEALTH.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_HEALTH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_HEALTH.Location = new System.Drawing.Point(20, 106);
            this.ESP_HEALTH.Name = "ESP_HEALTH";
            this.ESP_HEALTH.Size = new System.Drawing.Size(107, 32);
            this.ESP_HEALTH.TabIndex = 5;
            this.ESP_HEALTH.Text = "HEALTH";
            // 
            // ESP_ROBOT
            // 
            this.ESP_ROBOT.AutoSize = true;
            this.ESP_ROBOT.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_ROBOT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_ROBOT.Location = new System.Drawing.Point(20, 223);
            this.ESP_ROBOT.Name = "ESP_ROBOT";
            this.ESP_ROBOT.Size = new System.Drawing.Size(63, 32);
            this.ESP_ROBOT.TabIndex = 6;
            this.ESP_ROBOT.Text = "BOT";
            // 
            // ESP_ITEM_DISTANCE
            // 
            this.ESP_ITEM_DISTANCE.AutoSize = true;
            this.ESP_ITEM_DISTANCE.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_ITEM_DISTANCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_ITEM_DISTANCE.Location = new System.Drawing.Point(425, 55);
            this.ESP_ITEM_DISTANCE.Name = "ESP_ITEM_DISTANCE";
            this.ESP_ITEM_DISTANCE.Size = new System.Drawing.Size(132, 32);
            this.ESP_ITEM_DISTANCE.TabIndex = 8;
            this.ESP_ITEM_DISTANCE.Text = "DISTANCE";
            // 
            // ESP_LINES
            // 
            this.ESP_LINES.AutoSize = true;
            this.ESP_LINES.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_LINES.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_LINES.Location = new System.Drawing.Point(20, 65);
            this.ESP_LINES.Name = "ESP_LINES";
            this.ESP_LINES.Size = new System.Drawing.Size(80, 32);
            this.ESP_LINES.TabIndex = 10;
            this.ESP_LINES.Text = "LINES";
            // 
            // ESP_BOT_HEALTH
            // 
            this.ESP_BOT_HEALTH.AutoSize = true;
            this.ESP_BOT_HEALTH.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_BOT_HEALTH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_BOT_HEALTH.Location = new System.Drawing.Point(20, 264);
            this.ESP_BOT_HEALTH.Name = "ESP_BOT_HEALTH";
            this.ESP_BOT_HEALTH.Size = new System.Drawing.Size(132, 32);
            this.ESP_BOT_HEALTH.TabIndex = 15;
            this.ESP_BOT_HEALTH.Text = "DISTANCE";
            // 
            // PLAYER_ESP_BUTTON
            // 
            this.PLAYER_ESP_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PLAYER_ESP_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PLAYER_ESP_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAYER_ESP_BUTTON.Location = new System.Drawing.Point(183, 22);
            this.PLAYER_ESP_BUTTON.Name = "PLAYER_ESP_BUTTON";
            this.PLAYER_ESP_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.PLAYER_ESP_BUTTON.TabIndex = 16;
            this.PLAYER_ESP_BUTTON.Text = "OFF";
            this.PLAYER_ESP_BUTTON.UseVisualStyleBackColor = false;
            this.PLAYER_ESP_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_LINES_BUTTON
            // 
            this.ESP_LINES_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_LINES_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_LINES_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_LINES_BUTTON.Location = new System.Drawing.Point(183, 65);
            this.ESP_LINES_BUTTON.Name = "ESP_LINES_BUTTON";
            this.ESP_LINES_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_LINES_BUTTON.TabIndex = 17;
            this.ESP_LINES_BUTTON.Text = "OFF";
            this.ESP_LINES_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_LINES_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_SUPPLY_BOX_BUTTON
            // 
            this.ESP_SUPPLY_BOX_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_SUPPLY_BOX_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_SUPPLY_BOX_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_SUPPLY_BOX_BUTTON.Location = new System.Drawing.Point(612, 217);
            this.ESP_SUPPLY_BOX_BUTTON.Name = "ESP_SUPPLY_BOX_BUTTON";
            this.ESP_SUPPLY_BOX_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_SUPPLY_BOX_BUTTON.TabIndex = 19;
            this.ESP_SUPPLY_BOX_BUTTON.Text = "OFF";
            this.ESP_SUPPLY_BOX_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_SUPPLY_BOX_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_ITEM_DISTANCE_BUTTON
            // 
            this.ESP_ITEM_DISTANCE_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_ITEM_DISTANCE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_ITEM_DISTANCE_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_ITEM_DISTANCE_BUTTON.Location = new System.Drawing.Point(612, 55);
            this.ESP_ITEM_DISTANCE_BUTTON.Name = "ESP_ITEM_DISTANCE_BUTTON";
            this.ESP_ITEM_DISTANCE_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_ITEM_DISTANCE_BUTTON.TabIndex = 20;
            this.ESP_ITEM_DISTANCE_BUTTON.Text = "OFF";
            this.ESP_ITEM_DISTANCE_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_ITEM_DISTANCE_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_ITEM_BUTTON
            // 
            this.ESP_ITEM_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_ITEM_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_ITEM_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_ITEM_BUTTON.Location = new System.Drawing.Point(612, 12);
            this.ESP_ITEM_BUTTON.Name = "ESP_ITEM_BUTTON";
            this.ESP_ITEM_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_ITEM_BUTTON.TabIndex = 21;
            this.ESP_ITEM_BUTTON.Text = "OFF";
            this.ESP_ITEM_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_ITEM_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_BOT_HEALTH_BUTTON
            // 
            this.ESP_BOT_HEALTH_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_BOT_HEALTH_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_BOT_HEALTH_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_BOT_HEALTH_BUTTON.Location = new System.Drawing.Point(183, 267);
            this.ESP_BOT_HEALTH_BUTTON.Name = "ESP_BOT_HEALTH_BUTTON";
            this.ESP_BOT_HEALTH_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_BOT_HEALTH_BUTTON.TabIndex = 22;
            this.ESP_BOT_HEALTH_BUTTON.Text = "OFF";
            this.ESP_BOT_HEALTH_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_BOT_HEALTH_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_BOT_BUTTON
            // 
            this.ESP_BOT_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_BOT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_BOT_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_BOT_BUTTON.Location = new System.Drawing.Point(183, 223);
            this.ESP_BOT_BUTTON.Name = "ESP_BOT_BUTTON";
            this.ESP_BOT_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_BOT_BUTTON.TabIndex = 23;
            this.ESP_BOT_BUTTON.Text = "OFF";
            this.ESP_BOT_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_BOT_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_PLAYER_DISTANCE_BUTTON
            // 
            this.ESP_PLAYER_DISTANCE_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_PLAYER_DISTANCE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_PLAYER_DISTANCE_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_PLAYER_DISTANCE_BUTTON.Location = new System.Drawing.Point(183, 149);
            this.ESP_PLAYER_DISTANCE_BUTTON.Name = "ESP_PLAYER_DISTANCE_BUTTON";
            this.ESP_PLAYER_DISTANCE_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_PLAYER_DISTANCE_BUTTON.TabIndex = 24;
            this.ESP_PLAYER_DISTANCE_BUTTON.Text = "OFF";
            this.ESP_PLAYER_DISTANCE_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_PLAYER_DISTANCE_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_HEALTH_BUTTON
            // 
            this.ESP_HEALTH_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_HEALTH_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_HEALTH_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_HEALTH_BUTTON.Location = new System.Drawing.Point(183, 109);
            this.ESP_HEALTH_BUTTON.Name = "ESP_HEALTH_BUTTON";
            this.ESP_HEALTH_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_HEALTH_BUTTON.TabIndex = 25;
            this.ESP_HEALTH_BUTTON.Text = "OFF";
            this.ESP_HEALTH_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_HEALTH_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_VEHICLE_BUTTON
            // 
            this.ESP_VEHICLE_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_VEHICLE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_VEHICLE_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_VEHICLE_BUTTON.Location = new System.Drawing.Point(612, 133);
            this.ESP_VEHICLE_BUTTON.Name = "ESP_VEHICLE_BUTTON";
            this.ESP_VEHICLE_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_VEHICLE_BUTTON.TabIndex = 29;
            this.ESP_VEHICLE_BUTTON.Text = "OFF";
            this.ESP_VEHICLE_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_VEHICLE_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // ESP_VEHICLE_DISTANCE_BUTTON
            // 
            this.ESP_VEHICLE_DISTANCE_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_VEHICLE_DISTANCE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_VEHICLE_DISTANCE_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_VEHICLE_DISTANCE_BUTTON.Location = new System.Drawing.Point(612, 176);
            this.ESP_VEHICLE_DISTANCE_BUTTON.Name = "ESP_VEHICLE_DISTANCE_BUTTON";
            this.ESP_VEHICLE_DISTANCE_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_VEHICLE_DISTANCE_BUTTON.TabIndex = 28;
            this.ESP_VEHICLE_DISTANCE_BUTTON.Text = "OFF";
            this.ESP_VEHICLE_DISTANCE_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_VEHICLE_DISTANCE_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // VEHICLE_DISTANCE
            // 
            this.VEHICLE_DISTANCE.AutoSize = true;
            this.VEHICLE_DISTANCE.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VEHICLE_DISTANCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VEHICLE_DISTANCE.Location = new System.Drawing.Point(425, 176);
            this.VEHICLE_DISTANCE.Name = "VEHICLE_DISTANCE";
            this.VEHICLE_DISTANCE.Size = new System.Drawing.Size(132, 32);
            this.VEHICLE_DISTANCE.TabIndex = 27;
            this.VEHICLE_DISTANCE.Text = "DISTANCE";
            // 
            // ESP_VEHICLE
            // 
            this.ESP_VEHICLE.AutoSize = true;
            this.ESP_VEHICLE.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_VEHICLE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ESP_VEHICLE.Location = new System.Drawing.Point(425, 133);
            this.ESP_VEHICLE.Name = "ESP_VEHICLE";
            this.ESP_VEHICLE.Size = new System.Drawing.Size(109, 32);
            this.ESP_VEHICLE.TabIndex = 26;
            this.ESP_VEHICLE.Text = "VEHICLE";
            // 
            // ESP_PLANE_BUTTON
            // 
            this.ESP_PLANE_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ESP_PLANE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESP_PLANE_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_PLANE_BUTTON.Location = new System.Drawing.Point(612, 258);
            this.ESP_PLANE_BUTTON.Name = "ESP_PLANE_BUTTON";
            this.ESP_PLANE_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.ESP_PLANE_BUTTON.TabIndex = 31;
            this.ESP_PLANE_BUTTON.Text = "OFF";
            this.ESP_PLANE_BUTTON.UseVisualStyleBackColor = false;
            this.ESP_PLANE_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // PLANE_ESP
            // 
            this.PLANE_ESP.AutoSize = true;
            this.PLANE_ESP.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLANE_ESP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PLANE_ESP.Location = new System.Drawing.Point(425, 258);
            this.PLANE_ESP.Name = "PLANE_ESP";
            this.PLANE_ESP.Size = new System.Drawing.Size(91, 32);
            this.PLANE_ESP.TabIndex = 30;
            this.PLANE_ESP.Text = "PLANE";
            // 
            // TABS
            // 
            this.TABS.Controls.Add(this.ESP_TAB);
            this.TABS.Controls.Add(this.AIMBOT_TAB);
            this.TABS.Controls.Add(this.NOCLIP_TAB);
            this.TABS.Controls.Add(this.MISC_TAB);
            this.TABS.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TABS.Location = new System.Drawing.Point(12, 65);
            this.TABS.Name = "TABS";
            this.TABS.SelectedIndex = 0;
            this.TABS.Size = new System.Drawing.Size(777, 344);
            this.TABS.TabIndex = 36;
            // 
            // ESP_TAB
            // 
            this.ESP_TAB.BackColor = System.Drawing.Color.Black;
            this.ESP_TAB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ESP_TAB.Controls.Add(this.GOLD_ITEM_ESP_BUTTON);
            this.ESP_TAB.Controls.Add(this.box);
            this.ESP_TAB.Controls.Add(this.label2);
            this.ESP_TAB.Controls.Add(this.BOX_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_PLAYER_DISTANCE_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_PLAYER);
            this.ESP_TAB.Controls.Add(this.ESP_ITEM);
            this.ESP_TAB.Controls.Add(this.ESP_PLAYER_DISTANCE);
            this.ESP_TAB.Controls.Add(this.ESP_SUPPLY);
            this.ESP_TAB.Controls.Add(this.ESP_PLANE_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_HEALTH);
            this.ESP_TAB.Controls.Add(this.PLANE_ESP);
            this.ESP_TAB.Controls.Add(this.ESP_ROBOT);
            this.ESP_TAB.Controls.Add(this.ESP_VEHICLE_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_ITEM_DISTANCE);
            this.ESP_TAB.Controls.Add(this.ESP_VEHICLE_DISTANCE_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_LINES);
            this.ESP_TAB.Controls.Add(this.VEHICLE_DISTANCE);
            this.ESP_TAB.Controls.Add(this.ESP_BOT_HEALTH);
            this.ESP_TAB.Controls.Add(this.ESP_VEHICLE);
            this.ESP_TAB.Controls.Add(this.PLAYER_ESP_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_HEALTH_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_LINES_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_SUPPLY_BOX_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_BOT_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_ITEM_DISTANCE_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_BOT_HEALTH_BUTTON);
            this.ESP_TAB.Controls.Add(this.ESP_ITEM_BUTTON);
            this.ESP_TAB.Location = new System.Drawing.Point(4, 32);
            this.ESP_TAB.Name = "ESP_TAB";
            this.ESP_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.ESP_TAB.Size = new System.Drawing.Size(769, 308);
            this.ESP_TAB.TabIndex = 0;
            this.ESP_TAB.Text = "VISUAL";
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.box.Location = new System.Drawing.Point(20, 187);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(105, 32);
            this.box.TabIndex = 32;
            this.box.Text = "2D BOX";
            // 
            // BOX_BUTTON
            // 
            this.BOX_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BOX_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOX_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOX_BUTTON.Location = new System.Drawing.Point(183, 187);
            this.BOX_BUTTON.Name = "BOX_BUTTON";
            this.BOX_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.BOX_BUTTON.TabIndex = 33;
            this.BOX_BUTTON.Text = "OFF";
            this.BOX_BUTTON.UseVisualStyleBackColor = false;
            this.BOX_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // AIMBOT_TAB
            // 
            this.AIMBOT_TAB.BackColor = System.Drawing.Color.Black;
            this.AIMBOT_TAB.Controls.Add(this.AIMBOT_BUTTON);
            this.AIMBOT_TAB.Controls.Add(this.AIMBOT);
            this.AIMBOT_TAB.Controls.Add(this.SHOW_FOV_BUTTON);
            this.AIMBOT_TAB.Controls.Add(this.FOV_SHOW);
            this.AIMBOT_TAB.Controls.Add(this.SCOPE_BUTTON);
            this.AIMBOT_TAB.Controls.Add(this.scope);
            this.AIMBOT_TAB.Controls.Add(this.label1);
            this.AIMBOT_TAB.Controls.Add(this.HOLDKEY_BUTTON);
            this.AIMBOT_TAB.Controls.Add(this.SMARTAIM);
            this.AIMBOT_TAB.Controls.Add(this.SMARTAIM_BUTTON);
            this.AIMBOT_TAB.Controls.Add(this.FOV_BAR);
            this.AIMBOT_TAB.Controls.Add(this.FOV_LABEL);
            this.AIMBOT_TAB.Controls.Add(this.RANGE_AIMBOT);
            this.AIMBOT_TAB.Controls.Add(this.AIMBOT_DISTANCE);
            this.AIMBOT_TAB.Location = new System.Drawing.Point(4, 32);
            this.AIMBOT_TAB.Name = "AIMBOT_TAB";
            this.AIMBOT_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.AIMBOT_TAB.Size = new System.Drawing.Size(769, 308);
            this.AIMBOT_TAB.TabIndex = 1;
            this.AIMBOT_TAB.Text = "AIMBOT";
            // 
            // AIMBOT_BUTTON
            // 
            this.AIMBOT_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AIMBOT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AIMBOT_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIMBOT_BUTTON.Location = new System.Drawing.Point(182, 23);
            this.AIMBOT_BUTTON.Name = "AIMBOT_BUTTON";
            this.AIMBOT_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.AIMBOT_BUTTON.TabIndex = 35;
            this.AIMBOT_BUTTON.Text = "OFF";
            this.AIMBOT_BUTTON.UseVisualStyleBackColor = false;
            this.AIMBOT_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // AIMBOT
            // 
            this.AIMBOT.AutoSize = true;
            this.AIMBOT.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIMBOT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AIMBOT.Location = new System.Drawing.Point(19, 26);
            this.AIMBOT.Name = "AIMBOT";
            this.AIMBOT.Size = new System.Drawing.Size(110, 32);
            this.AIMBOT.TabIndex = 34;
            this.AIMBOT.Text = "AIMBOT";
            // 
            // SHOW_FOV_BUTTON
            // 
            this.SHOW_FOV_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SHOW_FOV_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SHOW_FOV_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOW_FOV_BUTTON.Location = new System.Drawing.Point(595, 78);
            this.SHOW_FOV_BUTTON.Name = "SHOW_FOV_BUTTON";
            this.SHOW_FOV_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.SHOW_FOV_BUTTON.TabIndex = 45;
            this.SHOW_FOV_BUTTON.Text = "OFF";
            this.SHOW_FOV_BUTTON.UseVisualStyleBackColor = false;
            this.SHOW_FOV_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // FOV_SHOW
            // 
            this.FOV_SHOW.AutoSize = true;
            this.FOV_SHOW.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOV_SHOW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FOV_SHOW.Location = new System.Drawing.Point(420, 78);
            this.FOV_SHOW.Name = "FOV_SHOW";
            this.FOV_SHOW.Size = new System.Drawing.Size(146, 32);
            this.FOV_SHOW.TabIndex = 44;
            this.FOV_SHOW.Text = "SHOW FOV";
            // 
            // SCOPE_BUTTON
            // 
            this.SCOPE_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SCOPE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SCOPE_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCOPE_BUTTON.Location = new System.Drawing.Point(595, 26);
            this.SCOPE_BUTTON.Name = "SCOPE_BUTTON";
            this.SCOPE_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.SCOPE_BUTTON.TabIndex = 43;
            this.SCOPE_BUTTON.Text = "NO, x2";
            this.SCOPE_BUTTON.UseVisualStyleBackColor = false;
            this.SCOPE_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // scope
            // 
            this.scope.AutoSize = true;
            this.scope.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scope.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scope.Location = new System.Drawing.Point(420, 23);
            this.scope.Name = "scope";
            this.scope.Size = new System.Drawing.Size(91, 32);
            this.scope.TabIndex = 42;
            this.scope.Text = "SCOPE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "HOLD KEY";
            // 
            // HOLDKEY_BUTTON
            // 
            this.HOLDKEY_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HOLDKEY_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOLDKEY_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOLDKEY_BUTTON.Location = new System.Drawing.Point(182, 259);
            this.HOLDKEY_BUTTON.Name = "HOLDKEY_BUTTON";
            this.HOLDKEY_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.HOLDKEY_BUTTON.TabIndex = 41;
            this.HOLDKEY_BUTTON.Text = "OFF";
            this.HOLDKEY_BUTTON.UseVisualStyleBackColor = false;
            this.HOLDKEY_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // SMARTAIM
            // 
            this.SMARTAIM.AutoSize = true;
            this.SMARTAIM.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMARTAIM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SMARTAIM.Location = new System.Drawing.Point(19, 199);
            this.SMARTAIM.Name = "SMARTAIM";
            this.SMARTAIM.Size = new System.Drawing.Size(154, 32);
            this.SMARTAIM.TabIndex = 38;
            this.SMARTAIM.Text = "SMART AIM";
            this.SMARTAIM.Click += new System.EventHandler(this.Buttons_click);
            // 
            // SMARTAIM_BUTTON
            // 
            this.SMARTAIM_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SMARTAIM_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMARTAIM_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMARTAIM_BUTTON.Location = new System.Drawing.Point(182, 199);
            this.SMARTAIM_BUTTON.Name = "SMARTAIM_BUTTON";
            this.SMARTAIM_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.SMARTAIM_BUTTON.TabIndex = 39;
            this.SMARTAIM_BUTTON.Text = "OFF";
            this.SMARTAIM_BUTTON.UseVisualStyleBackColor = false;
            this.SMARTAIM_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // FOV_BAR
            // 
            this.FOV_BAR.LargeChange = 10;
            this.FOV_BAR.Location = new System.Drawing.Point(182, 137);
            this.FOV_BAR.Maximum = 200;
            this.FOV_BAR.Minimum = 10;
            this.FOV_BAR.Name = "FOV_BAR";
            this.FOV_BAR.Size = new System.Drawing.Size(124, 56);
            this.FOV_BAR.SmallChange = 2;
            this.FOV_BAR.TabIndex = 37;
            this.FOV_BAR.Value = 10;
            this.FOV_BAR.Scroll += new System.EventHandler(this.FOV_BAR_Scroll);
            // 
            // FOV_LABEL
            // 
            this.FOV_LABEL.AutoSize = true;
            this.FOV_LABEL.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOV_LABEL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FOV_LABEL.Location = new System.Drawing.Point(19, 137);
            this.FOV_LABEL.Name = "FOV_LABEL";
            this.FOV_LABEL.Size = new System.Drawing.Size(63, 32);
            this.FOV_LABEL.TabIndex = 36;
            this.FOV_LABEL.Text = "FOV";
            // 
            // RANGE_AIMBOT
            // 
            this.RANGE_AIMBOT.LargeChange = 100;
            this.RANGE_AIMBOT.Location = new System.Drawing.Point(182, 78);
            this.RANGE_AIMBOT.Maximum = 1000;
            this.RANGE_AIMBOT.Name = "RANGE_AIMBOT";
            this.RANGE_AIMBOT.Size = new System.Drawing.Size(124, 56);
            this.RANGE_AIMBOT.SmallChange = 50;
            this.RANGE_AIMBOT.TabIndex = 35;
            this.RANGE_AIMBOT.Value = 10;
            this.RANGE_AIMBOT.Scroll += new System.EventHandler(this.Scrolled);
            // 
            // AIMBOT_DISTANCE
            // 
            this.AIMBOT_DISTANCE.AutoSize = true;
            this.AIMBOT_DISTANCE.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIMBOT_DISTANCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AIMBOT_DISTANCE.Location = new System.Drawing.Point(19, 78);
            this.AIMBOT_DISTANCE.Name = "AIMBOT_DISTANCE";
            this.AIMBOT_DISTANCE.Size = new System.Drawing.Size(132, 32);
            this.AIMBOT_DISTANCE.TabIndex = 34;
            this.AIMBOT_DISTANCE.Text = "DISTANCE";
            // 
            // NOCLIP_TAB
            // 
            this.NOCLIP_TAB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NOCLIP_TAB.Controls.Add(this.label3);
            this.NOCLIP_TAB.Controls.Add(this.WALLKILL_BUTTON);
            this.NOCLIP_TAB.Controls.Add(this.NOCLLIP_CONTROLS);
            this.NOCLIP_TAB.Controls.Add(this.NOCLIP);
            this.NOCLIP_TAB.Controls.Add(this.NOCLIP_BUTTON);
            this.NOCLIP_TAB.Location = new System.Drawing.Point(4, 32);
            this.NOCLIP_TAB.Name = "NOCLIP_TAB";
            this.NOCLIP_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.NOCLIP_TAB.Size = new System.Drawing.Size(769, 308);
            this.NOCLIP_TAB.TabIndex = 2;
            this.NOCLIP_TAB.Text = "NOCLIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "WallKill";
            // 
            // WALLKILL_BUTTON
            // 
            this.WALLKILL_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WALLKILL_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WALLKILL_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WALLKILL_BUTTON.Location = new System.Drawing.Point(178, 224);
            this.WALLKILL_BUTTON.Name = "WALLKILL_BUTTON";
            this.WALLKILL_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.WALLKILL_BUTTON.TabIndex = 36;
            this.WALLKILL_BUTTON.Text = "OFF";
            this.WALLKILL_BUTTON.UseVisualStyleBackColor = false;
            this.WALLKILL_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // NOCLLIP_CONTROLS
            // 
            this.NOCLLIP_CONTROLS.AutoSize = true;
            this.NOCLLIP_CONTROLS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NOCLLIP_CONTROLS.Location = new System.Drawing.Point(8, 98);
            this.NOCLLIP_CONTROLS.Name = "NOCLLIP_CONTROLS";
            this.NOCLLIP_CONTROLS.Size = new System.Drawing.Size(746, 72);
            this.NOCLLIP_CONTROLS.TabIndex = 34;
            this.NOCLLIP_CONTROLS.Text = "Right Control Key + Arrow Keys - Move Forward/Backward/Right/Left\r\nBack Space Key" +
    " - Fly Up\r\nRight Shift Key - Fly Down";
            // 
            // NOCLIP
            // 
            this.NOCLIP.AutoSize = true;
            this.NOCLIP.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOCLIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NOCLIP.Location = new System.Drawing.Point(15, 26);
            this.NOCLIP.Name = "NOCLIP";
            this.NOCLIP.Size = new System.Drawing.Size(102, 32);
            this.NOCLIP.TabIndex = 32;
            this.NOCLIP.Text = "NOCLIP";
            // 
            // NOCLIP_BUTTON
            // 
            this.NOCLIP_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NOCLIP_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NOCLIP_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOCLIP_BUTTON.Location = new System.Drawing.Point(178, 26);
            this.NOCLIP_BUTTON.Name = "NOCLIP_BUTTON";
            this.NOCLIP_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.NOCLIP_BUTTON.TabIndex = 33;
            this.NOCLIP_BUTTON.Text = "OFF";
            this.NOCLIP_BUTTON.UseVisualStyleBackColor = false;
            this.NOCLIP_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // MISC_TAB
            // 
            this.MISC_TAB.BackColor = System.Drawing.Color.Black;
            this.MISC_TAB.Controls.Add(this.NoGrassText);
            this.MISC_TAB.Controls.Add(this.NOGRASS_BUTTON);
            this.MISC_TAB.Location = new System.Drawing.Point(4, 32);
            this.MISC_TAB.Name = "MISC_TAB";
            this.MISC_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.MISC_TAB.Size = new System.Drawing.Size(769, 308);
            this.MISC_TAB.TabIndex = 3;
            this.MISC_TAB.Text = "Misc";
            // 
            // NoGrassText
            // 
            this.NoGrassText.AutoSize = true;
            this.NoGrassText.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoGrassText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoGrassText.Location = new System.Drawing.Point(24, 24);
            this.NoGrassText.Name = "NoGrassText";
            this.NoGrassText.Size = new System.Drawing.Size(110, 32);
            this.NoGrassText.TabIndex = 38;
            this.NoGrassText.Text = "NoGrass";
            // 
            // NOGRASS_BUTTON
            // 
            this.NOGRASS_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NOGRASS_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NOGRASS_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOGRASS_BUTTON.Location = new System.Drawing.Point(187, 24);
            this.NOGRASS_BUTTON.Name = "NOGRASS_BUTTON";
            this.NOGRASS_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.NOGRASS_BUTTON.TabIndex = 39;
            this.NOGRASS_BUTTON.Text = "OFF";
            this.NOGRASS_BUTTON.UseVisualStyleBackColor = false;
            // 
            // credit
            // 
            this.credit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.credit.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.credit.Location = new System.Drawing.Point(9, 9);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(780, 53);
            this.credit.TabIndex = 37;
            this.credit.Text = "ROS ULTRAHACK V2.1 by Ashesh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(425, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "GOLD ITEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GOLD_ITEM_ESP_BUTTON
            // 
            this.GOLD_ITEM_ESP_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GOLD_ITEM_ESP_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GOLD_ITEM_ESP_BUTTON.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GOLD_ITEM_ESP_BUTTON.Location = new System.Drawing.Point(612, 93);
            this.GOLD_ITEM_ESP_BUTTON.Name = "GOLD_ITEM_ESP_BUTTON";
            this.GOLD_ITEM_ESP_BUTTON.Size = new System.Drawing.Size(124, 32);
            this.GOLD_ITEM_ESP_BUTTON.TabIndex = 35;
            this.GOLD_ITEM_ESP_BUTTON.Text = "OFF";
            this.GOLD_ITEM_ESP_BUTTON.UseVisualStyleBackColor = false;
            this.GOLD_ITEM_ESP_BUTTON.Click += new System.EventHandler(this.Buttons_click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1068, 647);
            this.ControlBox = false;
            this.Controls.Add(this.credit);
            this.Controls.Add(this.TABS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menu";
            this.Opacity = 0.5D;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.TABS.ResumeLayout(false);
            this.ESP_TAB.ResumeLayout(false);
            this.ESP_TAB.PerformLayout();
            this.AIMBOT_TAB.ResumeLayout(false);
            this.AIMBOT_TAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOV_BAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RANGE_AIMBOT)).EndInit();
            this.NOCLIP_TAB.ResumeLayout(false);
            this.NOCLIP_TAB.PerformLayout();
            this.MISC_TAB.ResumeLayout(false);
            this.MISC_TAB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label ESP_PLAYER;
        public System.Windows.Forms.Label ESP_ITEM;
        public System.Windows.Forms.Label ESP_PLAYER_DISTANCE;
        public System.Windows.Forms.Label ESP_SUPPLY;
        public System.Windows.Forms.Label ESP_HEALTH;
        public System.Windows.Forms.Label ESP_ROBOT;
        public System.Windows.Forms.Label ESP_ITEM_DISTANCE;
        public System.Windows.Forms.Label ESP_LINES;
        public System.Windows.Forms.Label ESP_BOT_HEALTH;
        public System.Windows.Forms.Button PLAYER_ESP_BUTTON;
        public System.Windows.Forms.Button ESP_LINES_BUTTON;
        public System.Windows.Forms.Button ESP_SUPPLY_BOX_BUTTON;
        public System.Windows.Forms.Button ESP_ITEM_DISTANCE_BUTTON;
        public System.Windows.Forms.Button ESP_ITEM_BUTTON;
        public System.Windows.Forms.Button ESP_BOT_HEALTH_BUTTON;
        public System.Windows.Forms.Button ESP_BOT_BUTTON;
        public System.Windows.Forms.Button ESP_PLAYER_DISTANCE_BUTTON;
        public System.Windows.Forms.Button ESP_HEALTH_BUTTON;
        public System.Windows.Forms.Button ESP_VEHICLE_BUTTON;
        public System.Windows.Forms.Button ESP_VEHICLE_DISTANCE_BUTTON;
        public System.Windows.Forms.Label VEHICLE_DISTANCE;
        public System.Windows.Forms.Label ESP_VEHICLE;
        public Button ESP_PLANE_BUTTON;
        public Label PLANE_ESP;
        private TabControl TABS;
        private TabPage ESP_TAB;
        private TabPage AIMBOT_TAB;
        public Label NOCLIP;
        private TrackBar RANGE_AIMBOT;
        public Button NOCLIP_BUTTON;
        public Label AIMBOT_DISTANCE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TrackBar FOV_BAR;
        public Label FOV_LABEL;
        public Label SMARTAIM;
        public Button SMARTAIM_BUTTON;
        public Label label1;
        public Button HOLDKEY_BUTTON;
        private Label credit;
        public Button SCOPE_BUTTON;
        public Label scope;
        private TabPage NOCLIP_TAB;
        public Button SHOW_FOV_BUTTON;
        public Label FOV_SHOW;
        public Label AIMBOT;
        public Button AIMBOT_BUTTON;
        private Label NOCLLIP_CONTROLS;
        private TabPage MISC_TAB;
        public Label label3;
        public Button WALLKILL_BUTTON;
        public Label box;
        public Button BOX_BUTTON;
        public Label NoGrassText;
        public Button NOGRASS_BUTTON;
        public Button GOLD_ITEM_ESP_BUTTON;
        public Label label2;
    }
}