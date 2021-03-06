﻿using Mtgdb.Controls;

namespace Mtgdb.Gui
{
	partial class FormRoot
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoot));
			this._tabs = new Mtgdb.Controls.TabHeaderControl();
			this._buttonUndo = new Mtgdb.Controls.CustomCheckBox();
			this._buttonRedo = new Mtgdb.Controls.CustomCheckBox();
			this._buttonDonate = new Mtgdb.Controls.CustomCheckBox();
			this._buttonDownload = new Mtgdb.Controls.CustomCheckBox();
			this._buttonLanguage = new Mtgdb.Controls.CustomCheckBox();
			this._buttonConfig = new Mtgdb.Controls.CustomCheckBox();
			this._buttonHelp = new Mtgdb.Controls.CustomCheckBox();
			this._buttonClear = new Mtgdb.Controls.CustomCheckBox();
			this._buttonPrint = new Mtgdb.Controls.CustomCheckBox();
			this._buttonStat = new Mtgdb.Controls.CustomCheckBox();
			this._buttonSaveDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonOpenDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonTooltips = new Mtgdb.Controls.CustomCheckBox();
			this._menuOpen = new Mtgdb.Controls.BorderedPanel();
			this._layoutOpen = new System.Windows.Forms.TableLayoutPanel();
			this._buttonMenuSaveCollection = new Mtgdb.Controls.CustomCheckBox();
			this._labelMagarena = new System.Windows.Forms.Label();
			this._buttonMenuSaveDeck = new Mtgdb.Controls.CustomCheckBox();
			this._labelDotP2 = new System.Windows.Forms.Label();
			this._buttonMenuOpenCollection = new Mtgdb.Controls.CustomCheckBox();
			this._labelMtgo = new System.Windows.Forms.Label();
			this._buttonMenuOpenDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitMtgo = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitCockatrice = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitDotP2014 = new Mtgdb.Controls.CustomCheckBox();
			this._labelFormats = new System.Windows.Forms.Label();
			this._buttonVisitForge = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitXMage = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitMagarena = new Mtgdb.Controls.CustomCheckBox();
			this._menuLanguage = new Mtgdb.Controls.BorderedPanel();
			this._layoutLanguage = new System.Windows.Forms.TableLayoutPanel();
			this._buttonPT = new Mtgdb.Controls.CustomCheckBox();
			this._buttonDE = new Mtgdb.Controls.CustomCheckBox();
			this._buttonCN = new Mtgdb.Controls.CustomCheckBox();
			this._buttonEN = new Mtgdb.Controls.CustomCheckBox();
			this._buttonTW = new Mtgdb.Controls.CustomCheckBox();
			this._buttonIT = new Mtgdb.Controls.CustomCheckBox();
			this._buttonJP = new Mtgdb.Controls.CustomCheckBox();
			this._buttonKR = new Mtgdb.Controls.CustomCheckBox();
			this._buttonFR = new Mtgdb.Controls.CustomCheckBox();
			this._buttonES = new Mtgdb.Controls.CustomCheckBox();
			this._buttonRU = new Mtgdb.Controls.CustomCheckBox();
			this._menuDonate = new Mtgdb.Controls.BorderedPanel();
			this._layoutDonate = new System.Windows.Forms.TableLayoutPanel();
			this._buttonDonateYandexMoney = new Mtgdb.Controls.CustomCheckBox();
			this._panelAva = new Mtgdb.Controls.BorderedPanel();
			this._buttonDonatePayPal = new Mtgdb.Controls.CustomCheckBox();
			this._labelDonate = new System.Windows.Forms.Label();
			this._buttonPaste = new Mtgdb.Controls.CustomCheckBox();
			this._menuPaste = new Mtgdb.Controls.BorderedPanel();
			this._layoutPaste = new System.Windows.Forms.TableLayoutPanel();
			this._buttonMenuCopyCollection = new Mtgdb.Controls.CustomCheckBox();
			this._buttonMenuCopyDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonMenuPasteCollectionAppend = new Mtgdb.Controls.CustomCheckBox();
			this._buttonMenuPasteCollection = new Mtgdb.Controls.CustomCheckBox();
			this._labelPasteInfo = new System.Windows.Forms.Label();
			this._buttonMenuPasteDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonMenuPasteDeckAppend = new Mtgdb.Controls.CustomCheckBox();
			this._layoutTitle = new Mtgdb.Controls.BorderedTableLayoutPanel();
			this._flowTitleRight = new System.Windows.Forms.FlowLayoutPanel();
			this._buttonFilterPanels = new Mtgdb.Controls.CustomCheckBox();
			this._flowTitleLeft = new System.Windows.Forms.FlowLayoutPanel();
			this._buttonOpenWindow = new Mtgdb.Controls.CustomCheckBox();
			this._panelHeader.SuspendLayout();
			this._menuOpen.SuspendLayout();
			this._layoutOpen.SuspendLayout();
			this._menuLanguage.SuspendLayout();
			this._layoutLanguage.SuspendLayout();
			this._menuDonate.SuspendLayout();
			this._layoutDonate.SuspendLayout();
			this._menuPaste.SuspendLayout();
			this._layoutPaste.SuspendLayout();
			this._layoutTitle.SuspendLayout();
			this._flowTitleRight.SuspendLayout();
			this._flowTitleLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// _panelClient
			// 
			this._panelClient.Location = new System.Drawing.Point(4, 33);
			this._panelClient.Size = new System.Drawing.Size(992, 763);
			// 
			// _panelHeader
			// 
			this._panelHeader.Controls.Add(this._layoutTitle);
			this._panelHeader.Size = new System.Drawing.Size(802, 29);
			// 
			// _tabs
			// 
			this._tabs.AddButtonSlopeSize = new System.Drawing.Size(9, 17);
			this._tabs.AddButtonWidth = 24;
			this._tabs.AddIcon = global::Mtgdb.Gui.Properties.Resources.add_tab_32;
			this._tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._tabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._tabs.CloseIcon = global::Mtgdb.Gui.Properties.Resources.close_tab_32;
			this._tabs.CloseIconHovered = global::Mtgdb.Gui.Properties.Resources.close_tab_hovered_32;
			this._tabs.ColorSelected = System.Drawing.SystemColors.Control;
			this._tabs.ColorSelectedHovered = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this._tabs.ColorTabBorder = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this._tabs.ColorUnselected = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
			this._tabs.ColorUnselectedHovered = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this._tabs.DrawBottomBorder = true;
			this._tabs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._tabs.Location = new System.Drawing.Point(108, 1);
			this._tabs.Margin = new System.Windows.Forms.Padding(0);
			this._tabs.Name = "_tabs";
			this._tabs.Size = new System.Drawing.Size(42, 27);
			this._tabs.SlopeSize = new System.Drawing.Size(15, 27);
			this._tabs.TabIndex = 4;
			this._tabs.TabStop = false;
			// 
			// _buttonUndo
			// 
			this._buttonUndo.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonUndo.FlatAppearance.BorderSize = 0;
			this._buttonUndo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonUndo.Image = global::Mtgdb.Gui.Properties.Resources.undo_16;
			this._buttonUndo.Location = new System.Drawing.Point(0, 3);
			this._buttonUndo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonUndo.Name = "_buttonUndo";
			this._buttonUndo.Size = new System.Drawing.Size(32, 24);
			this._buttonUndo.TabIndex = 5;
			this._buttonUndo.TabStop = false;
			this._buttonUndo.UseVisualStyleBackColor = true;
			// 
			// _buttonRedo
			// 
			this._buttonRedo.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonRedo.FlatAppearance.BorderSize = 0;
			this._buttonRedo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonRedo.Image = global::Mtgdb.Gui.Properties.Resources.redo_16;
			this._buttonRedo.Location = new System.Drawing.Point(32, 3);
			this._buttonRedo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonRedo.Name = "_buttonRedo";
			this._buttonRedo.Size = new System.Drawing.Size(32, 24);
			this._buttonRedo.TabIndex = 6;
			this._buttonRedo.TabStop = false;
			this._buttonRedo.UseVisualStyleBackColor = true;
			// 
			// _buttonDonate
			// 
			this._buttonDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonDonate.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonDonate.FlatAppearance.BorderSize = 0;
			this._buttonDonate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonDonate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonDonate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonDonate.Location = new System.Drawing.Point(470, 3);
			this._buttonDonate.Margin = new System.Windows.Forms.Padding(0, 3, 12, 0);
			this._buttonDonate.Name = "_buttonDonate";
			this._buttonDonate.Size = new System.Drawing.Size(50, 24);
			this._buttonDonate.TabIndex = 7;
			this._buttonDonate.TabStop = false;
			this._buttonDonate.Text = "donate";
			this._buttonDonate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._buttonDonate.UseVisualStyleBackColor = true;
			// 
			// _buttonDownload
			// 
			this._buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonDownload.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonDownload.FlatAppearance.BorderSize = 0;
			this._buttonDownload.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonDownload.Image = global::Mtgdb.Gui.Properties.Resources.update_40;
			this._buttonDownload.Location = new System.Drawing.Point(426, 3);
			this._buttonDownload.Margin = new System.Windows.Forms.Padding(0, 3, 12, 0);
			this._buttonDownload.Name = "_buttonDownload";
			this._buttonDownload.Size = new System.Drawing.Size(32, 24);
			this._buttonDownload.TabIndex = 8;
			this._buttonDownload.TabStop = false;
			this._buttonDownload.UseVisualStyleBackColor = true;
			// 
			// _buttonLanguage
			// 
			this._buttonLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonLanguage.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonLanguage.BackColor = System.Drawing.Color.White;
			this._buttonLanguage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
			this._buttonLanguage.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonLanguage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this._buttonLanguage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this._buttonLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonLanguage.Image = global::Mtgdb.Gui.Properties.Resources.en;
			this._buttonLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonLanguage.Location = new System.Drawing.Point(356, 3);
			this._buttonLanguage.Margin = new System.Windows.Forms.Padding(0, 3, 12, 0);
			this._buttonLanguage.Name = "_buttonLanguage";
			this._buttonLanguage.Size = new System.Drawing.Size(58, 22);
			this._buttonLanguage.TabIndex = 9;
			this._buttonLanguage.TabStop = false;
			this._buttonLanguage.Text = "EN";
			this._buttonLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._buttonLanguage.UseVisualStyleBackColor = false;
			// 
			// _buttonConfig
			// 
			this._buttonConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonConfig.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonConfig.FlatAppearance.BorderSize = 0;
			this._buttonConfig.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonConfig.Image = global::Mtgdb.Gui.Properties.Resources.properties_16;
			this._buttonConfig.Location = new System.Drawing.Point(324, 3);
			this._buttonConfig.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonConfig.Name = "_buttonConfig";
			this._buttonConfig.Size = new System.Drawing.Size(32, 24);
			this._buttonConfig.TabIndex = 10;
			this._buttonConfig.TabStop = false;
			this._buttonConfig.UseVisualStyleBackColor = true;
			// 
			// _buttonHelp
			// 
			this._buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonHelp.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonHelp.FlatAppearance.BorderSize = 0;
			this._buttonHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonHelp.Image = global::Mtgdb.Gui.Properties.Resources.index_16;
			this._buttonHelp.Location = new System.Drawing.Point(228, 3);
			this._buttonHelp.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonHelp.Name = "_buttonHelp";
			this._buttonHelp.Size = new System.Drawing.Size(32, 24);
			this._buttonHelp.TabIndex = 12;
			this._buttonHelp.TabStop = false;
			this._buttonHelp.UseVisualStyleBackColor = true;
			// 
			// _buttonClear
			// 
			this._buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonClear.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonClear.FlatAppearance.BorderSize = 0;
			this._buttonClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonClear.Image = global::Mtgdb.Gui.Properties.Resources.trash_16;
			this._buttonClear.Location = new System.Drawing.Point(184, 3);
			this._buttonClear.Margin = new System.Windows.Forms.Padding(0, 3, 12, 0);
			this._buttonClear.Name = "_buttonClear";
			this._buttonClear.Size = new System.Drawing.Size(32, 24);
			this._buttonClear.TabIndex = 13;
			this._buttonClear.TabStop = false;
			this._buttonClear.UseVisualStyleBackColor = true;
			// 
			// _buttonPrint
			// 
			this._buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonPrint.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonPrint.FlatAppearance.BorderSize = 0;
			this._buttonPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonPrint.Image = global::Mtgdb.Gui.Properties.Resources.print_16;
			this._buttonPrint.Location = new System.Drawing.Point(120, 3);
			this._buttonPrint.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonPrint.Name = "_buttonPrint";
			this._buttonPrint.Size = new System.Drawing.Size(32, 24);
			this._buttonPrint.TabIndex = 14;
			this._buttonPrint.TabStop = false;
			this._buttonPrint.UseVisualStyleBackColor = true;
			// 
			// _buttonStat
			// 
			this._buttonStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonStat.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonStat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonStat.FlatAppearance.BorderSize = 0;
			this._buttonStat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonStat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonStat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonStat.Image = global::Mtgdb.Gui.Properties.Resources.chart_16;
			this._buttonStat.Location = new System.Drawing.Point(152, 3);
			this._buttonStat.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonStat.Name = "_buttonStat";
			this._buttonStat.Size = new System.Drawing.Size(32, 24);
			this._buttonStat.TabIndex = 15;
			this._buttonStat.TabStop = false;
			this._buttonStat.UseVisualStyleBackColor = true;
			// 
			// _buttonSaveDeck
			// 
			this._buttonSaveDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonSaveDeck.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonSaveDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonSaveDeck.FlatAppearance.BorderSize = 0;
			this._buttonSaveDeck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonSaveDeck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonSaveDeck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonSaveDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonSaveDeck.Image = global::Mtgdb.Gui.Properties.Resources.save_16;
			this._buttonSaveDeck.Location = new System.Drawing.Point(76, 3);
			this._buttonSaveDeck.Margin = new System.Windows.Forms.Padding(0, 3, 12, 0);
			this._buttonSaveDeck.Name = "_buttonSaveDeck";
			this._buttonSaveDeck.Size = new System.Drawing.Size(32, 24);
			this._buttonSaveDeck.TabIndex = 16;
			this._buttonSaveDeck.TabStop = false;
			this._buttonSaveDeck.UseVisualStyleBackColor = true;
			// 
			// _buttonOpenDeck
			// 
			this._buttonOpenDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonOpenDeck.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonOpenDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonOpenDeck.FlatAppearance.BorderSize = 0;
			this._buttonOpenDeck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonOpenDeck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonOpenDeck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonOpenDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonOpenDeck.Image = global::Mtgdb.Gui.Properties.Resources.open_16;
			this._buttonOpenDeck.Location = new System.Drawing.Point(44, 3);
			this._buttonOpenDeck.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonOpenDeck.Name = "_buttonOpenDeck";
			this._buttonOpenDeck.Size = new System.Drawing.Size(32, 24);
			this._buttonOpenDeck.TabIndex = 17;
			this._buttonOpenDeck.TabStop = false;
			this._buttonOpenDeck.UseVisualStyleBackColor = true;
			// 
			// _buttonTooltips
			// 
			this._buttonTooltips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonTooltips.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonTooltips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonTooltips.Checked = true;
			this._buttonTooltips.CheckState = System.Windows.Forms.CheckState.Checked;
			this._buttonTooltips.FlatAppearance.BorderSize = 0;
			this._buttonTooltips.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
			this._buttonTooltips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonTooltips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonTooltips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonTooltips.Image = global::Mtgdb.Gui.Properties.Resources.tooltip_16;
			this._buttonTooltips.Location = new System.Drawing.Point(260, 3);
			this._buttonTooltips.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonTooltips.Name = "_buttonTooltips";
			this._buttonTooltips.Size = new System.Drawing.Size(32, 24);
			this._buttonTooltips.TabIndex = 18;
			this._buttonTooltips.TabStop = false;
			this._buttonTooltips.UseVisualStyleBackColor = true;
			// 
			// _menuOpen
			// 
			this._menuOpen.AutoSize = true;
			this._menuOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._menuOpen.BackColor = System.Drawing.Color.White;
			this._menuOpen.Controls.Add(this._layoutOpen);
			this._menuOpen.Location = new System.Drawing.Point(349, 287);
			this._menuOpen.Margin = new System.Windows.Forms.Padding(0);
			this._menuOpen.Name = "_menuOpen";
			this._menuOpen.Size = new System.Drawing.Size(272, 445);
			this._menuOpen.TabIndex = 0;
			this._menuOpen.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _layoutOpen
			// 
			this._layoutOpen.AutoSize = true;
			this._layoutOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._layoutOpen.ColumnCount = 3;
			this._layoutOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutOpen.Controls.Add(this._buttonMenuSaveCollection, 0, 3);
			this._layoutOpen.Controls.Add(this._labelMagarena, 1, 8);
			this._layoutOpen.Controls.Add(this._buttonMenuSaveDeck, 0, 2);
			this._layoutOpen.Controls.Add(this._labelDotP2, 1, 7);
			this._layoutOpen.Controls.Add(this._buttonMenuOpenCollection, 0, 1);
			this._layoutOpen.Controls.Add(this._labelMtgo, 1, 6);
			this._layoutOpen.Controls.Add(this._buttonMenuOpenDeck, 0, 0);
			this._layoutOpen.Controls.Add(this._buttonVisitMtgo, 0, 6);
			this._layoutOpen.Controls.Add(this._buttonVisitCockatrice, 0, 8);
			this._layoutOpen.Controls.Add(this._buttonVisitDotP2014, 0, 7);
			this._layoutOpen.Controls.Add(this._labelFormats, 0, 4);
			this._layoutOpen.Controls.Add(this._buttonVisitForge, 0, 5);
			this._layoutOpen.Controls.Add(this._buttonVisitXMage, 1, 5);
			this._layoutOpen.Controls.Add(this._buttonVisitMagarena, 2, 5);
			this._layoutOpen.Location = new System.Drawing.Point(1, 1);
			this._layoutOpen.Margin = new System.Windows.Forms.Padding(1);
			this._layoutOpen.Name = "_layoutOpen";
			this._layoutOpen.RowCount = 9;
			this._layoutOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutOpen.Size = new System.Drawing.Size(270, 443);
			this._layoutOpen.TabIndex = 0;
			// 
			// _buttonMenuSaveCollection
			// 
			this._buttonMenuSaveCollection.Appearance = System.Windows.Forms.Appearance.Button;
			this._layoutOpen.SetColumnSpan(this._buttonMenuSaveCollection, 3);
			this._buttonMenuSaveCollection.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuSaveCollection.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuSaveCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuSaveCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuSaveCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuSaveCollection.Image = global::Mtgdb.Gui.Properties.Resources.box_48;
			this._buttonMenuSaveCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuSaveCollection.Location = new System.Drawing.Point(2, 110);
			this._buttonMenuSaveCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuSaveCollection.Name = "_buttonMenuSaveCollection";
			this._buttonMenuSaveCollection.Size = new System.Drawing.Size(266, 34);
			this._buttonMenuSaveCollection.TabIndex = 34;
			this._buttonMenuSaveCollection.TabStop = false;
			this._buttonMenuSaveCollection.Text = "              Save collection to file: Ctrl+Alt+S";
			this._buttonMenuSaveCollection.UseVisualStyleBackColor = true;
			// 
			// _labelMagarena
			// 
			this._labelMagarena.BackColor = System.Drawing.Color.Transparent;
			this._layoutOpen.SetColumnSpan(this._labelMagarena, 2);
			this._labelMagarena.Location = new System.Drawing.Point(104, 387);
			this._labelMagarena.Margin = new System.Windows.Forms.Padding(3);
			this._labelMagarena.Name = "_labelMagarena";
			this._labelMagarena.Size = new System.Drawing.Size(163, 25);
			this._labelMagarena.TabIndex = 9;
			this._labelMagarena.Text = "* Supports Magarena format";
			this._labelMagarena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _buttonMenuSaveDeck
			// 
			this._buttonMenuSaveDeck.Appearance = System.Windows.Forms.Appearance.Button;
			this._layoutOpen.SetColumnSpan(this._buttonMenuSaveDeck, 3);
			this._buttonMenuSaveDeck.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuSaveDeck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuSaveDeck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuSaveDeck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuSaveDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuSaveDeck.Image = global::Mtgdb.Gui.Properties.Resources.deck_48;
			this._buttonMenuSaveDeck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuSaveDeck.Location = new System.Drawing.Point(2, 74);
			this._buttonMenuSaveDeck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuSaveDeck.Name = "_buttonMenuSaveDeck";
			this._buttonMenuSaveDeck.Size = new System.Drawing.Size(266, 34);
			this._buttonMenuSaveDeck.TabIndex = 33;
			this._buttonMenuSaveDeck.TabStop = false;
			this._buttonMenuSaveDeck.Text = "              Save deck to file: Ctrl+S";
			this._buttonMenuSaveDeck.UseVisualStyleBackColor = true;
			// 
			// _labelDotP2
			// 
			this._labelDotP2.BackColor = System.Drawing.Color.Transparent;
			this._layoutOpen.SetColumnSpan(this._labelDotP2, 2);
			this._labelDotP2.Location = new System.Drawing.Point(104, 308);
			this._labelDotP2.Margin = new System.Windows.Forms.Padding(3);
			this._labelDotP2.Name = "_labelDotP2";
			this._labelDotP2.Size = new System.Drawing.Size(163, 36);
			this._labelDotP2.TabIndex = 12;
			this._labelDotP2.Text = "* Modified version supports Forge format";
			this._labelDotP2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _buttonMenuOpenCollection
			// 
			this._buttonMenuOpenCollection.Appearance = System.Windows.Forms.Appearance.Button;
			this._layoutOpen.SetColumnSpan(this._buttonMenuOpenCollection, 3);
			this._buttonMenuOpenCollection.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuOpenCollection.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuOpenCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuOpenCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuOpenCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuOpenCollection.Image = global::Mtgdb.Gui.Properties.Resources.box_48;
			this._buttonMenuOpenCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuOpenCollection.Location = new System.Drawing.Point(2, 38);
			this._buttonMenuOpenCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuOpenCollection.Name = "_buttonMenuOpenCollection";
			this._buttonMenuOpenCollection.Size = new System.Drawing.Size(266, 34);
			this._buttonMenuOpenCollection.TabIndex = 31;
			this._buttonMenuOpenCollection.TabStop = false;
			this._buttonMenuOpenCollection.Text = "              Load collection from file: Ctrl+Alt+O";
			this._buttonMenuOpenCollection.UseVisualStyleBackColor = true;
			// 
			// _labelMtgo
			// 
			this._labelMtgo.BackColor = System.Drawing.Color.Transparent;
			this._layoutOpen.SetColumnSpan(this._labelMtgo, 2);
			this._labelMtgo.Location = new System.Drawing.Point(104, 226);
			this._labelMtgo.Margin = new System.Windows.Forms.Padding(3);
			this._labelMtgo.Name = "_labelMtgo";
			this._labelMtgo.Size = new System.Drawing.Size(162, 76);
			this._labelMtgo.TabIndex = 36;
			this._labelMtgo.Text = "* MTGO .txt format is supported in many websites including \r\n - magic.wizards.com" +
    "\r\n - www.mtggoldfish.com";
			this._labelMtgo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _buttonMenuOpenDeck
			// 
			this._buttonMenuOpenDeck.Appearance = System.Windows.Forms.Appearance.Button;
			this._layoutOpen.SetColumnSpan(this._buttonMenuOpenDeck, 3);
			this._buttonMenuOpenDeck.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuOpenDeck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuOpenDeck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuOpenDeck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuOpenDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuOpenDeck.Image = global::Mtgdb.Gui.Properties.Resources.deck_48;
			this._buttonMenuOpenDeck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuOpenDeck.Location = new System.Drawing.Point(2, 2);
			this._buttonMenuOpenDeck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuOpenDeck.Name = "_buttonMenuOpenDeck";
			this._buttonMenuOpenDeck.Size = new System.Drawing.Size(266, 34);
			this._buttonMenuOpenDeck.TabIndex = 30;
			this._buttonMenuOpenDeck.TabStop = false;
			this._buttonMenuOpenDeck.Text = "              Load deck(s) from file(s): Ctrl+O";
			this._buttonMenuOpenDeck.UseVisualStyleBackColor = true;
			// 
			// _buttonVisitMtgo
			// 
			this._buttonVisitMtgo.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonVisitMtgo.BackColor = System.Drawing.Color.White;
			this._buttonVisitMtgo.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitMtgo.FlatAppearance.BorderSize = 0;
			this._buttonVisitMtgo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonVisitMtgo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this._buttonVisitMtgo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this._buttonVisitMtgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonVisitMtgo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitMtgo.ForeColor = System.Drawing.Color.Blue;
			this._buttonVisitMtgo.Image = global::Mtgdb.Gui.Properties.Resources.mtgo_32;
			this._buttonVisitMtgo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this._buttonVisitMtgo.Location = new System.Drawing.Point(3, 226);
			this._buttonVisitMtgo.Name = "_buttonVisitMtgo";
			this._buttonVisitMtgo.Size = new System.Drawing.Size(95, 59);
			this._buttonVisitMtgo.TabIndex = 32;
			this._buttonVisitMtgo.TabStop = false;
			this._buttonVisitMtgo.Text = "Magic The Gathering Online";
			this._buttonVisitMtgo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._buttonVisitMtgo.UseVisualStyleBackColor = false;
			// 
			// _buttonVisitCockatrice
			// 
			this._buttonVisitCockatrice.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonVisitCockatrice.BackColor = System.Drawing.Color.White;
			this._buttonVisitCockatrice.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitCockatrice.FlatAppearance.BorderSize = 0;
			this._buttonVisitCockatrice.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonVisitCockatrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this._buttonVisitCockatrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this._buttonVisitCockatrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonVisitCockatrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitCockatrice.ForeColor = System.Drawing.Color.Blue;
			this._buttonVisitCockatrice.Image = global::Mtgdb.Gui.Properties.Resources.cockatrice_32;
			this._buttonVisitCockatrice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this._buttonVisitCockatrice.Location = new System.Drawing.Point(3, 387);
			this._buttonVisitCockatrice.Name = "_buttonVisitCockatrice";
			this._buttonVisitCockatrice.Size = new System.Drawing.Size(95, 53);
			this._buttonVisitCockatrice.TabIndex = 3;
			this._buttonVisitCockatrice.TabStop = false;
			this._buttonVisitCockatrice.Text = "Cockatrice";
			this._buttonVisitCockatrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._buttonVisitCockatrice.UseVisualStyleBackColor = false;
			// 
			// _buttonVisitDotP2014
			// 
			this._buttonVisitDotP2014.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonVisitDotP2014.BackColor = System.Drawing.Color.White;
			this._buttonVisitDotP2014.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitDotP2014.FlatAppearance.BorderSize = 0;
			this._buttonVisitDotP2014.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonVisitDotP2014.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this._buttonVisitDotP2014.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this._buttonVisitDotP2014.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonVisitDotP2014.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitDotP2014.ForeColor = System.Drawing.Color.Blue;
			this._buttonVisitDotP2014.Image = global::Mtgdb.Gui.Properties.Resources.dot_p2014_32;
			this._buttonVisitDotP2014.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this._buttonVisitDotP2014.Location = new System.Drawing.Point(3, 308);
			this._buttonVisitDotP2014.Name = "_buttonVisitDotP2014";
			this._buttonVisitDotP2014.Size = new System.Drawing.Size(95, 73);
			this._buttonVisitDotP2014.TabIndex = 4;
			this._buttonVisitDotP2014.TabStop = false;
			this._buttonVisitDotP2014.Text = "Riiak\'s DotP 2014 Deck Builder";
			this._buttonVisitDotP2014.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._buttonVisitDotP2014.UseVisualStyleBackColor = false;
			// 
			// _labelFormats
			// 
			this._labelFormats.AutoSize = true;
			this._labelFormats.BackColor = System.Drawing.Color.Transparent;
			this._layoutOpen.SetColumnSpan(this._labelFormats, 3);
			this._labelFormats.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._labelFormats.Location = new System.Drawing.Point(3, 147);
			this._labelFormats.Margin = new System.Windows.Forms.Padding(3);
			this._labelFormats.Name = "_labelFormats";
			this._labelFormats.Size = new System.Drawing.Size(114, 14);
			this._labelFormats.TabIndex = 6;
			this._labelFormats.Text = "Supported formats:";
			this._labelFormats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _buttonVisitForge
			// 
			this._buttonVisitForge.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonVisitForge.BackColor = System.Drawing.Color.White;
			this._buttonVisitForge.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitForge.FlatAppearance.BorderSize = 0;
			this._buttonVisitForge.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonVisitForge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this._buttonVisitForge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this._buttonVisitForge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonVisitForge.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitForge.ForeColor = System.Drawing.Color.Blue;
			this._buttonVisitForge.Image = global::Mtgdb.Gui.Properties.Resources.forge_32;
			this._buttonVisitForge.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this._buttonVisitForge.Location = new System.Drawing.Point(3, 167);
			this._buttonVisitForge.Name = "_buttonVisitForge";
			this._buttonVisitForge.Size = new System.Drawing.Size(95, 53);
			this._buttonVisitForge.TabIndex = 0;
			this._buttonVisitForge.TabStop = false;
			this._buttonVisitForge.Text = "Forge";
			this._buttonVisitForge.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._buttonVisitForge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._buttonVisitForge.UseVisualStyleBackColor = false;
			// 
			// _buttonVisitXMage
			// 
			this._buttonVisitXMage.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonVisitXMage.BackColor = System.Drawing.Color.White;
			this._buttonVisitXMage.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitXMage.FlatAppearance.BorderSize = 0;
			this._buttonVisitXMage.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonVisitXMage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this._buttonVisitXMage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this._buttonVisitXMage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonVisitXMage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitXMage.ForeColor = System.Drawing.Color.Blue;
			this._buttonVisitXMage.Image = global::Mtgdb.Gui.Properties.Resources.xmage_32;
			this._buttonVisitXMage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this._buttonVisitXMage.Location = new System.Drawing.Point(104, 167);
			this._buttonVisitXMage.Name = "_buttonVisitXMage";
			this._buttonVisitXMage.Size = new System.Drawing.Size(56, 53);
			this._buttonVisitXMage.TabIndex = 1;
			this._buttonVisitXMage.TabStop = false;
			this._buttonVisitXMage.Text = "XMage";
			this._buttonVisitXMage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._buttonVisitXMage.UseVisualStyleBackColor = false;
			// 
			// _buttonVisitMagarena
			// 
			this._buttonVisitMagarena.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonVisitMagarena.BackColor = System.Drawing.Color.White;
			this._buttonVisitMagarena.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitMagarena.FlatAppearance.BorderSize = 0;
			this._buttonVisitMagarena.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonVisitMagarena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this._buttonVisitMagarena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this._buttonVisitMagarena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonVisitMagarena.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitMagarena.ForeColor = System.Drawing.Color.Blue;
			this._buttonVisitMagarena.Image = global::Mtgdb.Gui.Properties.Resources.magarena_32;
			this._buttonVisitMagarena.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this._buttonVisitMagarena.Location = new System.Drawing.Point(166, 167);
			this._buttonVisitMagarena.Name = "_buttonVisitMagarena";
			this._buttonVisitMagarena.Size = new System.Drawing.Size(63, 53);
			this._buttonVisitMagarena.TabIndex = 2;
			this._buttonVisitMagarena.TabStop = false;
			this._buttonVisitMagarena.Text = "Magarena";
			this._buttonVisitMagarena.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._buttonVisitMagarena.UseVisualStyleBackColor = false;
			// 
			// _menuLanguage
			// 
			this._menuLanguage.AutoSize = true;
			this._menuLanguage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._menuLanguage.BackColor = System.Drawing.Color.White;
			this._menuLanguage.Controls.Add(this._layoutLanguage);
			this._menuLanguage.Location = new System.Drawing.Point(693, 62);
			this._menuLanguage.Margin = new System.Windows.Forms.Padding(0);
			this._menuLanguage.Name = "_menuLanguage";
			this._menuLanguage.Size = new System.Drawing.Size(176, 90);
			this._menuLanguage.TabIndex = 13;
			this._menuLanguage.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _layoutLanguage
			// 
			this._layoutLanguage.AutoSize = true;
			this._layoutLanguage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._layoutLanguage.ColumnCount = 3;
			this._layoutLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutLanguage.Controls.Add(this._buttonPT, 1, 3);
			this._layoutLanguage.Controls.Add(this._buttonDE, 2, 1);
			this._layoutLanguage.Controls.Add(this._buttonCN, 0, 0);
			this._layoutLanguage.Controls.Add(this._buttonEN, 2, 0);
			this._layoutLanguage.Controls.Add(this._buttonTW, 0, 3);
			this._layoutLanguage.Controls.Add(this._buttonIT, 1, 2);
			this._layoutLanguage.Controls.Add(this._buttonJP, 0, 1);
			this._layoutLanguage.Controls.Add(this._buttonKR, 0, 2);
			this._layoutLanguage.Controls.Add(this._buttonFR, 1, 1);
			this._layoutLanguage.Controls.Add(this._buttonES, 1, 0);
			this._layoutLanguage.Controls.Add(this._buttonRU, 2, 2);
			this._layoutLanguage.Location = new System.Drawing.Point(1, 1);
			this._layoutLanguage.Margin = new System.Windows.Forms.Padding(1);
			this._layoutLanguage.Name = "_layoutLanguage";
			this._layoutLanguage.RowCount = 4;
			this._layoutLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutLanguage.Size = new System.Drawing.Size(174, 88);
			this._layoutLanguage.TabIndex = 38;
			// 
			// _buttonPT
			// 
			this._buttonPT.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonPT.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonPT.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonPT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonPT.Image = global::Mtgdb.Gui.Properties.Resources.pt;
			this._buttonPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonPT.Location = new System.Drawing.Point(58, 66);
			this._buttonPT.Margin = new System.Windows.Forms.Padding(0);
			this._buttonPT.Name = "_buttonPT";
			this._buttonPT.Size = new System.Drawing.Size(58, 22);
			this._buttonPT.TabIndex = 28;
			this._buttonPT.TabStop = false;
			this._buttonPT.Text = "       PT";
			this._buttonPT.UseVisualStyleBackColor = false;
			// 
			// _buttonDE
			// 
			this._buttonDE.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonDE.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonDE.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonDE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonDE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonDE.Image = global::Mtgdb.Gui.Properties.Resources.de;
			this._buttonDE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonDE.Location = new System.Drawing.Point(116, 22);
			this._buttonDE.Margin = new System.Windows.Forms.Padding(0);
			this._buttonDE.Name = "_buttonDE";
			this._buttonDE.Size = new System.Drawing.Size(58, 22);
			this._buttonDE.TabIndex = 23;
			this._buttonDE.TabStop = false;
			this._buttonDE.Text = "       DE";
			this._buttonDE.UseVisualStyleBackColor = false;
			// 
			// _buttonCN
			// 
			this._buttonCN.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonCN.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonCN.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonCN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonCN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonCN.Image = global::Mtgdb.Gui.Properties.Resources.cn;
			this._buttonCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonCN.Location = new System.Drawing.Point(0, 0);
			this._buttonCN.Margin = new System.Windows.Forms.Padding(0);
			this._buttonCN.Name = "_buttonCN";
			this._buttonCN.Size = new System.Drawing.Size(58, 22);
			this._buttonCN.TabIndex = 18;
			this._buttonCN.TabStop = false;
			this._buttonCN.Text = "       CN";
			this._buttonCN.UseVisualStyleBackColor = false;
			// 
			// _buttonEN
			// 
			this._buttonEN.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonEN.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonEN.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonEN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonEN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonEN.Image = global::Mtgdb.Gui.Properties.Resources.en;
			this._buttonEN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonEN.Location = new System.Drawing.Point(116, 0);
			this._buttonEN.Margin = new System.Windows.Forms.Padding(0);
			this._buttonEN.Name = "_buttonEN";
			this._buttonEN.Size = new System.Drawing.Size(58, 22);
			this._buttonEN.TabIndex = 20;
			this._buttonEN.TabStop = false;
			this._buttonEN.Text = "       EN";
			this._buttonEN.UseVisualStyleBackColor = false;
			// 
			// _buttonTW
			// 
			this._buttonTW.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonTW.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonTW.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonTW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonTW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonTW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonTW.Image = global::Mtgdb.Gui.Properties.Resources.tw;
			this._buttonTW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonTW.Location = new System.Drawing.Point(0, 66);
			this._buttonTW.Margin = new System.Windows.Forms.Padding(0);
			this._buttonTW.Name = "_buttonTW";
			this._buttonTW.Size = new System.Drawing.Size(58, 22);
			this._buttonTW.TabIndex = 27;
			this._buttonTW.TabStop = false;
			this._buttonTW.Text = "       TW";
			this._buttonTW.UseVisualStyleBackColor = false;
			// 
			// _buttonIT
			// 
			this._buttonIT.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonIT.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonIT.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonIT.Image = global::Mtgdb.Gui.Properties.Resources.it;
			this._buttonIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonIT.Location = new System.Drawing.Point(58, 44);
			this._buttonIT.Margin = new System.Windows.Forms.Padding(0);
			this._buttonIT.Name = "_buttonIT";
			this._buttonIT.Size = new System.Drawing.Size(58, 22);
			this._buttonIT.TabIndex = 25;
			this._buttonIT.TabStop = false;
			this._buttonIT.Text = "       IT";
			this._buttonIT.UseVisualStyleBackColor = false;
			// 
			// _buttonJP
			// 
			this._buttonJP.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonJP.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonJP.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonJP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonJP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonJP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonJP.Image = global::Mtgdb.Gui.Properties.Resources.jp;
			this._buttonJP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonJP.Location = new System.Drawing.Point(0, 22);
			this._buttonJP.Margin = new System.Windows.Forms.Padding(0);
			this._buttonJP.Name = "_buttonJP";
			this._buttonJP.Size = new System.Drawing.Size(58, 22);
			this._buttonJP.TabIndex = 21;
			this._buttonJP.TabStop = false;
			this._buttonJP.Text = "       JP";
			this._buttonJP.UseVisualStyleBackColor = false;
			// 
			// _buttonKR
			// 
			this._buttonKR.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonKR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonKR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonKR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonKR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonKR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonKR.Image = global::Mtgdb.Gui.Properties.Resources.kr;
			this._buttonKR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonKR.Location = new System.Drawing.Point(0, 44);
			this._buttonKR.Margin = new System.Windows.Forms.Padding(0);
			this._buttonKR.Name = "_buttonKR";
			this._buttonKR.Size = new System.Drawing.Size(58, 22);
			this._buttonKR.TabIndex = 24;
			this._buttonKR.TabStop = false;
			this._buttonKR.Text = "       KR";
			this._buttonKR.UseVisualStyleBackColor = false;
			// 
			// _buttonFR
			// 
			this._buttonFR.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonFR.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonFR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonFR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonFR.Image = global::Mtgdb.Gui.Properties.Resources.fr;
			this._buttonFR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonFR.Location = new System.Drawing.Point(58, 22);
			this._buttonFR.Margin = new System.Windows.Forms.Padding(0);
			this._buttonFR.Name = "_buttonFR";
			this._buttonFR.Size = new System.Drawing.Size(58, 22);
			this._buttonFR.TabIndex = 22;
			this._buttonFR.TabStop = false;
			this._buttonFR.Text = "       FR";
			this._buttonFR.UseVisualStyleBackColor = false;
			// 
			// _buttonES
			// 
			this._buttonES.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonES.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonES.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonES.Image = global::Mtgdb.Gui.Properties.Resources.es;
			this._buttonES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonES.Location = new System.Drawing.Point(58, 0);
			this._buttonES.Margin = new System.Windows.Forms.Padding(0);
			this._buttonES.Name = "_buttonES";
			this._buttonES.Size = new System.Drawing.Size(58, 22);
			this._buttonES.TabIndex = 19;
			this._buttonES.TabStop = false;
			this._buttonES.Text = "       ES";
			this._buttonES.UseVisualStyleBackColor = false;
			// 
			// _buttonRU
			// 
			this._buttonRU.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonRU.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonRU.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonRU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonRU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonRU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonRU.Image = global::Mtgdb.Gui.Properties.Resources.ru;
			this._buttonRU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonRU.Location = new System.Drawing.Point(116, 44);
			this._buttonRU.Margin = new System.Windows.Forms.Padding(0);
			this._buttonRU.Name = "_buttonRU";
			this._buttonRU.Size = new System.Drawing.Size(58, 22);
			this._buttonRU.TabIndex = 26;
			this._buttonRU.TabStop = false;
			this._buttonRU.Text = "       RU";
			this._buttonRU.UseVisualStyleBackColor = false;
			// 
			// _menuDonate
			// 
			this._menuDonate.AutoSize = true;
			this._menuDonate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._menuDonate.BackColor = System.Drawing.Color.White;
			this._menuDonate.Controls.Add(this._layoutDonate);
			this._menuDonate.Location = new System.Drawing.Point(35, 62);
			this._menuDonate.Margin = new System.Windows.Forms.Padding(0);
			this._menuDonate.Name = "_menuDonate";
			this._menuDonate.Size = new System.Drawing.Size(245, 195);
			this._menuDonate.TabIndex = 29;
			this._menuDonate.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _layoutDonate
			// 
			this._layoutDonate.AutoSize = true;
			this._layoutDonate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._layoutDonate.ColumnCount = 2;
			this._layoutDonate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutDonate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutDonate.Controls.Add(this._buttonDonateYandexMoney, 0, 2);
			this._layoutDonate.Controls.Add(this._panelAva, 0, 0);
			this._layoutDonate.Controls.Add(this._buttonDonatePayPal, 0, 1);
			this._layoutDonate.Controls.Add(this._labelDonate, 1, 0);
			this._layoutDonate.Location = new System.Drawing.Point(1, 1);
			this._layoutDonate.Margin = new System.Windows.Forms.Padding(1);
			this._layoutDonate.Name = "_layoutDonate";
			this._layoutDonate.RowCount = 3;
			this._layoutDonate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutDonate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutDonate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutDonate.Size = new System.Drawing.Size(243, 193);
			this._layoutDonate.TabIndex = 0;
			// 
			// _buttonDonateYandexMoney
			// 
			this._buttonDonateYandexMoney.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonDonateYandexMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._layoutDonate.SetColumnSpan(this._buttonDonateYandexMoney, 2);
			this._buttonDonateYandexMoney.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonDonateYandexMoney.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonDonateYandexMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonDonateYandexMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonDonateYandexMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonDonateYandexMoney.Image = global::Mtgdb.Gui.Properties.Resources.yandex_money_32;
			this._buttonDonateYandexMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonDonateYandexMoney.Location = new System.Drawing.Point(2, 157);
			this._buttonDonateYandexMoney.Margin = new System.Windows.Forms.Padding(2);
			this._buttonDonateYandexMoney.Name = "_buttonDonateYandexMoney";
			this._buttonDonateYandexMoney.Size = new System.Drawing.Size(239, 34);
			this._buttonDonateYandexMoney.TabIndex = 29;
			this._buttonDonateYandexMoney.TabStop = false;
			this._buttonDonateYandexMoney.Text = "            Donate via YandexMoney";
			this._buttonDonateYandexMoney.UseVisualStyleBackColor = true;
			// 
			// _panelAva
			// 
			this._panelAva.BackgroundImage = global::Mtgdb.Gui.Properties.Resources.ava;
			this._panelAva.Location = new System.Drawing.Point(2, 2);
			this._panelAva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._panelAva.Name = "_panelAva";
			this._panelAva.Size = new System.Drawing.Size(87, 117);
			this._panelAva.TabIndex = 0;
			this._panelAva.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _buttonDonatePayPal
			// 
			this._buttonDonatePayPal.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonDonatePayPal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._layoutDonate.SetColumnSpan(this._buttonDonatePayPal, 2);
			this._buttonDonatePayPal.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonDonatePayPal.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonDonatePayPal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonDonatePayPal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonDonatePayPal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonDonatePayPal.Image = global::Mtgdb.Gui.Properties.Resources.paypal_32;
			this._buttonDonatePayPal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonDonatePayPal.Location = new System.Drawing.Point(2, 121);
			this._buttonDonatePayPal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonDonatePayPal.Name = "_buttonDonatePayPal";
			this._buttonDonatePayPal.Size = new System.Drawing.Size(239, 34);
			this._buttonDonatePayPal.TabIndex = 30;
			this._buttonDonatePayPal.TabStop = false;
			this._buttonDonatePayPal.Text = "            Donate via PayPal";
			this._buttonDonatePayPal.UseVisualStyleBackColor = true;
			// 
			// _labelDonate
			// 
			this._labelDonate.Location = new System.Drawing.Point(94, 3);
			this._labelDonate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this._labelDonate.Name = "_labelDonate";
			this._labelDonate.Size = new System.Drawing.Size(146, 116);
			this._labelDonate.TabIndex = 31;
			this._labelDonate.Text = "This application is free.\r\n\r\nIf you like it, consider donating to support its mai" +
    "ntenance and further development.\r\n\r\nThank you!";
			// 
			// _buttonPaste
			// 
			this._buttonPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonPaste.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonPaste.FlatAppearance.BorderSize = 0;
			this._buttonPaste.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonPaste.Image = global::Mtgdb.Gui.Properties.Resources.paste_16;
			this._buttonPaste.Location = new System.Drawing.Point(0, 3);
			this._buttonPaste.Margin = new System.Windows.Forms.Padding(0, 3, 12, 0);
			this._buttonPaste.Name = "_buttonPaste";
			this._buttonPaste.Size = new System.Drawing.Size(32, 24);
			this._buttonPaste.TabIndex = 19;
			this._buttonPaste.TabStop = false;
			this._buttonPaste.UseVisualStyleBackColor = true;
			// 
			// _menuPaste
			// 
			this._menuPaste.AutoSize = true;
			this._menuPaste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._menuPaste.BackColor = System.Drawing.Color.White;
			this._menuPaste.Controls.Add(this._layoutPaste);
			this._menuPaste.Location = new System.Drawing.Point(35, 287);
			this._menuPaste.Margin = new System.Windows.Forms.Padding(0);
			this._menuPaste.Name = "_menuPaste";
			this._menuPaste.Size = new System.Drawing.Size(305, 461);
			this._menuPaste.TabIndex = 37;
			this._menuPaste.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _layoutPaste
			// 
			this._layoutPaste.AutoSize = true;
			this._layoutPaste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._layoutPaste.ColumnCount = 1;
			this._layoutPaste.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutPaste.Controls.Add(this._buttonMenuCopyCollection, 0, 5);
			this._layoutPaste.Controls.Add(this._buttonMenuCopyDeck, 0, 4);
			this._layoutPaste.Controls.Add(this._buttonMenuPasteCollectionAppend, 0, 3);
			this._layoutPaste.Controls.Add(this._buttonMenuPasteCollection, 0, 2);
			this._layoutPaste.Controls.Add(this._labelPasteInfo, 0, 6);
			this._layoutPaste.Controls.Add(this._buttonMenuPasteDeck, 0, 0);
			this._layoutPaste.Controls.Add(this._buttonMenuPasteDeckAppend, 0, 1);
			this._layoutPaste.Location = new System.Drawing.Point(1, 1);
			this._layoutPaste.Margin = new System.Windows.Forms.Padding(1);
			this._layoutPaste.Name = "_layoutPaste";
			this._layoutPaste.RowCount = 7;
			this._layoutPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._layoutPaste.Size = new System.Drawing.Size(303, 459);
			this._layoutPaste.TabIndex = 0;
			// 
			// _buttonMenuCopyCollection
			// 
			this._buttonMenuCopyCollection.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonMenuCopyCollection.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuCopyCollection.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuCopyCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuCopyCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuCopyCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuCopyCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuCopyCollection.Location = new System.Drawing.Point(2, 182);
			this._buttonMenuCopyCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuCopyCollection.Name = "_buttonMenuCopyCollection";
			this._buttonMenuCopyCollection.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuCopyCollection.TabIndex = 39;
			this._buttonMenuCopyCollection.TabStop = false;
			this._buttonMenuCopyCollection.Text = "Copy Collection to Clipboard: Alt + C";
			this._buttonMenuCopyCollection.UseVisualStyleBackColor = true;
			// 
			// _buttonMenuCopyDeck
			// 
			this._buttonMenuCopyDeck.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonMenuCopyDeck.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuCopyDeck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuCopyDeck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuCopyDeck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuCopyDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuCopyDeck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuCopyDeck.Location = new System.Drawing.Point(2, 146);
			this._buttonMenuCopyDeck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuCopyDeck.Name = "_buttonMenuCopyDeck";
			this._buttonMenuCopyDeck.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuCopyDeck.TabIndex = 38;
			this._buttonMenuCopyDeck.TabStop = false;
			this._buttonMenuCopyDeck.Text = "Copy Deck to Clipboard: Ctrl + C";
			this._buttonMenuCopyDeck.UseVisualStyleBackColor = true;
			// 
			// _buttonMenuPasteCollectionAppend
			// 
			this._buttonMenuPasteCollectionAppend.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonMenuPasteCollectionAppend.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuPasteCollectionAppend.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuPasteCollectionAppend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuPasteCollectionAppend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuPasteCollectionAppend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuPasteCollectionAppend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuPasteCollectionAppend.Location = new System.Drawing.Point(2, 110);
			this._buttonMenuPasteCollectionAppend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuPasteCollectionAppend.Name = "_buttonMenuPasteCollectionAppend";
			this._buttonMenuPasteCollectionAppend.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuPasteCollectionAppend.TabIndex = 37;
			this._buttonMenuPasteCollectionAppend.TabStop = false;
			this._buttonMenuPasteCollectionAppend.Text = "Add to Collection from Clipboard: Alt + Shift + V";
			this._buttonMenuPasteCollectionAppend.UseVisualStyleBackColor = true;
			// 
			// _buttonMenuPasteCollection
			// 
			this._buttonMenuPasteCollection.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonMenuPasteCollection.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuPasteCollection.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuPasteCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuPasteCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuPasteCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuPasteCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuPasteCollection.Location = new System.Drawing.Point(2, 74);
			this._buttonMenuPasteCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuPasteCollection.Name = "_buttonMenuPasteCollection";
			this._buttonMenuPasteCollection.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuPasteCollection.TabIndex = 36;
			this._buttonMenuPasteCollection.TabStop = false;
			this._buttonMenuPasteCollection.Text = "Create Collection from Clipboard: Alt + V";
			this._buttonMenuPasteCollection.UseVisualStyleBackColor = true;
			// 
			// _labelPasteInfo
			// 
			this._labelPasteInfo.Location = new System.Drawing.Point(3, 219);
			this._labelPasteInfo.Margin = new System.Windows.Forms.Padding(3);
			this._labelPasteInfo.Name = "_labelPasteInfo";
			this._labelPasteInfo.Size = new System.Drawing.Size(295, 237);
			this._labelPasteInfo.TabIndex = 35;
			this._labelPasteInfo.Text = resources.GetString("_labelPasteInfo.Text");
			this._labelPasteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _buttonMenuPasteDeck
			// 
			this._buttonMenuPasteDeck.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonMenuPasteDeck.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuPasteDeck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuPasteDeck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuPasteDeck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuPasteDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuPasteDeck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuPasteDeck.Location = new System.Drawing.Point(2, 2);
			this._buttonMenuPasteDeck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuPasteDeck.Name = "_buttonMenuPasteDeck";
			this._buttonMenuPasteDeck.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuPasteDeck.TabIndex = 33;
			this._buttonMenuPasteDeck.TabStop = false;
			this._buttonMenuPasteDeck.Text = "Create new Deck from Clipboard: Ctrl + V";
			this._buttonMenuPasteDeck.UseVisualStyleBackColor = true;
			// 
			// _buttonMenuPasteDeckAppend
			// 
			this._buttonMenuPasteDeckAppend.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonMenuPasteDeckAppend.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._buttonMenuPasteDeckAppend.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this._buttonMenuPasteDeckAppend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuPasteDeckAppend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite;
			this._buttonMenuPasteDeckAppend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonMenuPasteDeckAppend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._buttonMenuPasteDeckAppend.Location = new System.Drawing.Point(2, 38);
			this._buttonMenuPasteDeckAppend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuPasteDeckAppend.Name = "_buttonMenuPasteDeckAppend";
			this._buttonMenuPasteDeckAppend.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuPasteDeckAppend.TabIndex = 34;
			this._buttonMenuPasteDeckAppend.TabStop = false;
			this._buttonMenuPasteDeckAppend.Text = "Add to Deck from Clipboard: Ctrl + Shift + V";
			this._buttonMenuPasteDeckAppend.UseVisualStyleBackColor = true;
			// 
			// _layoutTitle
			// 
			this._layoutTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._layoutTitle.ColumnCount = 3;
			this._layoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._layoutTitle.Controls.Add(this._flowTitleRight, 2, 0);
			this._layoutTitle.Controls.Add(this._flowTitleLeft, 0, 0);
			this._layoutTitle.Controls.Add(this._tabs, 1, 0);
			this._layoutTitle.Location = new System.Drawing.Point(1, 1);
			this._layoutTitle.Margin = new System.Windows.Forms.Padding(1);
			this._layoutTitle.Name = "_layoutTitle";
			this._layoutTitle.RowCount = 1;
			this._layoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._layoutTitle.Size = new System.Drawing.Size(800, 28);
			this._layoutTitle.TabIndex = 20;
			this._layoutTitle.VisibleBorders = System.Windows.Forms.AnchorStyles.Bottom;
			// 
			// _flowTitleRight
			// 
			this._flowTitleRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._flowTitleRight.AutoSize = true;
			this._flowTitleRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._flowTitleRight.Controls.Add(this._buttonPaste);
			this._flowTitleRight.Controls.Add(this._buttonOpenDeck);
			this._flowTitleRight.Controls.Add(this._buttonSaveDeck);
			this._flowTitleRight.Controls.Add(this._buttonPrint);
			this._flowTitleRight.Controls.Add(this._buttonStat);
			this._flowTitleRight.Controls.Add(this._buttonClear);
			this._flowTitleRight.Controls.Add(this._buttonHelp);
			this._flowTitleRight.Controls.Add(this._buttonTooltips);
			this._flowTitleRight.Controls.Add(this._buttonFilterPanels);
			this._flowTitleRight.Controls.Add(this._buttonConfig);
			this._flowTitleRight.Controls.Add(this._buttonLanguage);
			this._flowTitleRight.Controls.Add(this._buttonDownload);
			this._flowTitleRight.Controls.Add(this._buttonDonate);
			this._flowTitleRight.Location = new System.Drawing.Point(268, 0);
			this._flowTitleRight.Margin = new System.Windows.Forms.Padding(0);
			this._flowTitleRight.Name = "_flowTitleRight";
			this._flowTitleRight.Size = new System.Drawing.Size(532, 27);
			this._flowTitleRight.TabIndex = 1;
			this._flowTitleRight.WrapContents = false;
			// 
			// _buttonFilterPanels
			// 
			this._buttonFilterPanels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonFilterPanels.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonFilterPanels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonFilterPanels.Checked = true;
			this._buttonFilterPanels.CheckState = System.Windows.Forms.CheckState.Checked;
			this._buttonFilterPanels.FlatAppearance.BorderSize = 0;
			this._buttonFilterPanels.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonFilterPanels.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonFilterPanels.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonFilterPanels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonFilterPanels.Image = global::Mtgdb.Gui.Properties.Resources.filters_show_32;
			this._buttonFilterPanels.Location = new System.Drawing.Point(292, 3);
			this._buttonFilterPanels.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonFilterPanels.Name = "_buttonFilterPanels";
			this._buttonFilterPanels.Size = new System.Drawing.Size(32, 24);
			this._buttonFilterPanels.TabIndex = 20;
			this._buttonFilterPanels.TabStop = false;
			this._buttonFilterPanels.UseVisualStyleBackColor = true;
			// 
			// _flowTitleLeft
			// 
			this._flowTitleLeft.AutoSize = true;
			this._flowTitleLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._flowTitleLeft.Controls.Add(this._buttonUndo);
			this._flowTitleLeft.Controls.Add(this._buttonRedo);
			this._flowTitleLeft.Controls.Add(this._buttonOpenWindow);
			this._flowTitleLeft.Location = new System.Drawing.Point(0, 0);
			this._flowTitleLeft.Margin = new System.Windows.Forms.Padding(0);
			this._flowTitleLeft.Name = "_flowTitleLeft";
			this._flowTitleLeft.Size = new System.Drawing.Size(108, 27);
			this._flowTitleLeft.TabIndex = 0;
			this._flowTitleLeft.WrapContents = false;
			// 
			// _buttonOpenWindow
			// 
			this._buttonOpenWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonOpenWindow.Appearance = System.Windows.Forms.Appearance.Button;
			this._buttonOpenWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._buttonOpenWindow.FlatAppearance.BorderSize = 0;
			this._buttonOpenWindow.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
			this._buttonOpenWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
			this._buttonOpenWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
			this._buttonOpenWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._buttonOpenWindow.Image = global::Mtgdb.Gui.Properties.Resources.add_form_32;
			this._buttonOpenWindow.Location = new System.Drawing.Point(64, 3);
			this._buttonOpenWindow.Margin = new System.Windows.Forms.Padding(0, 3, 12, 0);
			this._buttonOpenWindow.Name = "_buttonOpenWindow";
			this._buttonOpenWindow.Size = new System.Drawing.Size(32, 24);
			this._buttonOpenWindow.TabIndex = 20;
			this._buttonOpenWindow.TabStop = false;
			this._buttonOpenWindow.UseVisualStyleBackColor = true;
			// 
			// FormRoot
			// 
			this.ClientSize = new System.Drawing.Size(1000, 800);
			this.Controls.Add(this._menuOpen);
			this.Controls.Add(this._menuLanguage);
			this.Controls.Add(this._menuPaste);
			this.Controls.Add(this._menuDonate);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImageClose = global::Mtgdb.Gui.Properties.Resources.close;
			this.ImageMaximize = global::Mtgdb.Gui.Properties.Resources.maximize;
			this.ImageMinimize = global::Mtgdb.Gui.Properties.Resources.minimize;
			this.ImageNormalize = global::Mtgdb.Gui.Properties.Resources.normalize;
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "FormRoot";
			this.Text = "FormTabbed";
			this.TitleHeight = 33;
			this.Controls.SetChildIndex(this._panelClient, 0);
			this.Controls.SetChildIndex(this._menuDonate, 0);
			this.Controls.SetChildIndex(this._menuPaste, 0);
			this.Controls.SetChildIndex(this._panelHeader, 0);
			this.Controls.SetChildIndex(this._menuLanguage, 0);
			this.Controls.SetChildIndex(this._menuOpen, 0);
			this._panelHeader.ResumeLayout(false);
			this._menuOpen.ResumeLayout(false);
			this._menuOpen.PerformLayout();
			this._layoutOpen.ResumeLayout(false);
			this._layoutOpen.PerformLayout();
			this._menuLanguage.ResumeLayout(false);
			this._menuLanguage.PerformLayout();
			this._layoutLanguage.ResumeLayout(false);
			this._menuDonate.ResumeLayout(false);
			this._menuDonate.PerformLayout();
			this._layoutDonate.ResumeLayout(false);
			this._menuPaste.ResumeLayout(false);
			this._menuPaste.PerformLayout();
			this._layoutPaste.ResumeLayout(false);
			this._layoutTitle.ResumeLayout(false);
			this._layoutTitle.PerformLayout();
			this._flowTitleRight.ResumeLayout(false);
			this._flowTitleLeft.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Mtgdb.Controls.CustomCheckBox _buttonUndo;
		private Mtgdb.Controls.CustomCheckBox _buttonRedo;
		private Mtgdb.Controls.CustomCheckBox _buttonDonate;
		private Mtgdb.Controls.CustomCheckBox _buttonDownload;
		private Mtgdb.Controls.CustomCheckBox _buttonLanguage;
		private Mtgdb.Controls.CustomCheckBox _buttonConfig;
		private Mtgdb.Controls.CustomCheckBox _buttonHelp;
		private Mtgdb.Controls.CustomCheckBox _buttonOpenDeck;
		private Mtgdb.Controls.CustomCheckBox _buttonSaveDeck;
		private Mtgdb.Controls.CustomCheckBox _buttonStat;
		private Mtgdb.Controls.CustomCheckBox _buttonPrint;
		private Mtgdb.Controls.CustomCheckBox _buttonClear;
		private Mtgdb.Controls.CustomCheckBox _buttonTooltips;
		private Controls.TabHeaderControl _tabs;
		Mtgdb.Controls.BorderedPanel _menuOpen;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitForge;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitXMage;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitMagarena;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitCockatrice;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitDotP2014;
		private System.Windows.Forms.Label _labelFormats;
		private System.Windows.Forms.Label _labelMagarena;
		private System.Windows.Forms.Label _labelDotP2;
		private Controls.BorderedPanel _menuLanguage;
		private Mtgdb.Controls.CustomCheckBox _buttonPT;
		private Mtgdb.Controls.CustomCheckBox _buttonTW;
		private Mtgdb.Controls.CustomCheckBox _buttonRU;
		private Mtgdb.Controls.CustomCheckBox _buttonIT;
		private Mtgdb.Controls.CustomCheckBox _buttonKR;
		private Mtgdb.Controls.CustomCheckBox _buttonDE;
		private Mtgdb.Controls.CustomCheckBox _buttonFR;
		private Mtgdb.Controls.CustomCheckBox _buttonJP;
		private Mtgdb.Controls.CustomCheckBox _buttonEN;
		private Mtgdb.Controls.CustomCheckBox _buttonES;
		private Mtgdb.Controls.CustomCheckBox _buttonCN;
		private Controls.BorderedPanel _menuDonate;
		private Mtgdb.Controls.BorderedPanel _panelAva;
		private Mtgdb.Controls.CustomCheckBox _buttonDonatePayPal;
		private Mtgdb.Controls.CustomCheckBox _buttonDonateYandexMoney;
		private System.Windows.Forms.Label _labelDonate;
		private Controls.CustomCheckBox _buttonMenuOpenDeck;
		private Controls.CustomCheckBox _buttonMenuOpenCollection;
		private Controls.CustomCheckBox _buttonVisitMtgo;
		private Controls.CustomCheckBox _buttonMenuSaveDeck;
		private Controls.CustomCheckBox _buttonMenuSaveCollection;
		private System.Windows.Forms.Label _labelMtgo;
		private Controls.CustomCheckBox _buttonPaste;
		private Controls.BorderedPanel _menuPaste;
		private System.Windows.Forms.Label _labelPasteInfo;
		private Controls.CustomCheckBox _buttonMenuPasteDeckAppend;
		private Controls.CustomCheckBox _buttonMenuPasteDeck;
		private System.Windows.Forms.TableLayoutPanel _layoutOpen;
		private System.Windows.Forms.TableLayoutPanel _layoutPaste;
		private System.Windows.Forms.TableLayoutPanel _layoutDonate;
		private System.Windows.Forms.TableLayoutPanel _layoutLanguage;
		private Mtgdb.Controls.BorderedTableLayoutPanel _layoutTitle;
		private System.Windows.Forms.FlowLayoutPanel _flowTitleLeft;
		private System.Windows.Forms.FlowLayoutPanel _flowTitleRight;
		private CustomCheckBox _buttonMenuPasteCollectionAppend;
		private CustomCheckBox _buttonMenuPasteCollection;
		private CustomCheckBox _buttonMenuCopyDeck;
		private CustomCheckBox _buttonMenuCopyCollection;
		private CustomCheckBox _buttonFilterPanels;
		private CustomCheckBox _buttonOpenWindow;
	}
}