// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Mp3 {
    
    
    public partial class PreferencesWindow {
        
        private Gtk.Fixed fixedLaytout;
        
        private Gtk.Label behaviorLabel;
        
        private Gtk.VBox optionsVertBox;
        
        private Gtk.CheckButton behaviorButton1;
        
        private Gtk.CheckButton behaviorButton2;
        
        private Gtk.CheckButton behaviorButton3;
        
        private Gtk.CheckButton behaviorButton4;
        
        private Gtk.HBox customLibraryBox;
        
        private Gtk.Entry entry1;
        
        private Gtk.Button button23;
        
        private Gtk.CheckButton behaviorButton5;
        
        private Gtk.CheckButton behaviorButton6;
        
        private Gtk.Label preferencesLabel;
        
        private Gtk.HBox buttonSelectionBox;
        
        private Gtk.Button cancelButton;
        
        private Gtk.Button okButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget Mp3.PreferencesWindow
            this.WidthRequest = 390;
            this.HeightRequest = 290;
            this.Name = "Mp3.PreferencesWindow";
            this.Title = Mono.Unix.Catalog.GetString("Preferences");
            this.Icon = Stetic.IconLoader.LoadIcon("gtk-preferences", 16);
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.Resizable = false;
            this.AllowGrow = false;
            // Container child Mp3.PreferencesWindow.Gtk.Container+ContainerChild
            this.fixedLaytout = new Gtk.Fixed();
            this.fixedLaytout.Name = "fixedLaytout";
            this.fixedLaytout.HasWindow = false;
            // Container child fixedLaytout.Gtk.Fixed+FixedChild
            this.behaviorLabel = new Gtk.Label();
            this.behaviorLabel.Name = "behaviorLabel";
            this.behaviorLabel.LabelProp = Mono.Unix.Catalog.GetString("<b>Program Behavior</b>");
            this.behaviorLabel.UseMarkup = true;
            this.behaviorLabel.Wrap = true;
            this.fixedLaytout.Add(this.behaviorLabel);
            Gtk.Fixed.FixedChild w1 = ((Gtk.Fixed.FixedChild)(this.fixedLaytout[this.behaviorLabel]));
            w1.X = 31;
            w1.Y = 31;
            // Container child fixedLaytout.Gtk.Fixed+FixedChild
            this.optionsVertBox = new Gtk.VBox();
            this.optionsVertBox.Name = "optionsVertBox";
            this.optionsVertBox.Spacing = 6;
            // Container child optionsVertBox.Gtk.Box+BoxChild
            this.behaviorButton1 = new Gtk.CheckButton();
            this.behaviorButton1.CanFocus = true;
            this.behaviorButton1.Name = "behaviorButton1";
            this.behaviorButton1.Label = Mono.Unix.Catalog.GetString("Show above all other windows");
            this.behaviorButton1.DrawIndicator = true;
            this.behaviorButton1.UseUnderline = true;
            this.optionsVertBox.Add(this.behaviorButton1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.optionsVertBox[this.behaviorButton1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child optionsVertBox.Gtk.Box+BoxChild
            this.behaviorButton2 = new Gtk.CheckButton();
            this.behaviorButton2.CanFocus = true;
            this.behaviorButton2.Name = "behaviorButton2";
            this.behaviorButton2.Label = Mono.Unix.Catalog.GetString("Continue playing last song after restarting");
            this.behaviorButton2.DrawIndicator = true;
            this.behaviorButton2.UseUnderline = true;
            this.optionsVertBox.Add(this.behaviorButton2);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.optionsVertBox[this.behaviorButton2]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child optionsVertBox.Gtk.Box+BoxChild
            this.behaviorButton3 = new Gtk.CheckButton();
            this.behaviorButton3.CanFocus = true;
            this.behaviorButton3.Name = "behaviorButton3";
            this.behaviorButton3.Label = Mono.Unix.Catalog.GetString("Minimize to tray");
            this.behaviorButton3.DrawIndicator = true;
            this.behaviorButton3.UseUnderline = true;
            this.optionsVertBox.Add(this.behaviorButton3);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.optionsVertBox[this.behaviorButton3]));
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            // Container child optionsVertBox.Gtk.Box+BoxChild
            this.behaviorButton4 = new Gtk.CheckButton();
            this.behaviorButton4.CanFocus = true;
            this.behaviorButton4.Name = "behaviorButton4";
            this.behaviorButton4.Label = Mono.Unix.Catalog.GetString("Use custom library path");
            this.behaviorButton4.DrawIndicator = true;
            this.behaviorButton4.UseUnderline = true;
            this.optionsVertBox.Add(this.behaviorButton4);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.optionsVertBox[this.behaviorButton4]));
            w5.Position = 3;
            w5.Expand = false;
            w5.Fill = false;
            // Container child optionsVertBox.Gtk.Box+BoxChild
            this.customLibraryBox = new Gtk.HBox();
            this.customLibraryBox.Name = "customLibraryBox";
            this.customLibraryBox.Spacing = 6;
            // Container child customLibraryBox.Gtk.Box+BoxChild
            this.entry1 = new Gtk.Entry();
            this.entry1.CanFocus = true;
            this.entry1.Name = "entry1";
            this.entry1.IsEditable = true;
            this.entry1.InvisibleChar = '●';
            this.customLibraryBox.Add(this.entry1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.customLibraryBox[this.entry1]));
            w6.Position = 1;
            // Container child customLibraryBox.Gtk.Box+BoxChild
            this.button23 = new Gtk.Button();
            this.button23.CanFocus = true;
            this.button23.Name = "button23";
            this.button23.UseUnderline = true;
            this.button23.Label = Mono.Unix.Catalog.GetString("Browse");
            this.customLibraryBox.Add(this.button23);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.customLibraryBox[this.button23]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            this.optionsVertBox.Add(this.customLibraryBox);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.optionsVertBox[this.customLibraryBox]));
            w8.Position = 4;
            w8.Expand = false;
            w8.Fill = false;
            // Container child optionsVertBox.Gtk.Box+BoxChild
            this.behaviorButton5 = new Gtk.CheckButton();
            this.behaviorButton5.CanFocus = true;
            this.behaviorButton5.Name = "behaviorButton5";
            this.behaviorButton5.Label = Mono.Unix.Catalog.GetString("Search for albums without cover art");
            this.behaviorButton5.DrawIndicator = true;
            this.behaviorButton5.UseUnderline = true;
            this.optionsVertBox.Add(this.behaviorButton5);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.optionsVertBox[this.behaviorButton5]));
            w9.Position = 5;
            // Container child optionsVertBox.Gtk.Box+BoxChild
            this.behaviorButton6 = new Gtk.CheckButton();
            this.behaviorButton6.CanFocus = true;
            this.behaviorButton6.Name = "behaviorButton6";
            this.behaviorButton6.Label = Mono.Unix.Catalog.GetString("Search for song lyrics");
            this.behaviorButton6.DrawIndicator = true;
            this.behaviorButton6.UseUnderline = true;
            this.optionsVertBox.Add(this.behaviorButton6);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.optionsVertBox[this.behaviorButton6]));
            w10.Position = 6;
            w10.Expand = false;
            w10.Fill = false;
            this.fixedLaytout.Add(this.optionsVertBox);
            Gtk.Fixed.FixedChild w11 = ((Gtk.Fixed.FixedChild)(this.fixedLaytout[this.optionsVertBox]));
            w11.X = 28;
            w11.Y = 50;
            // Container child fixedLaytout.Gtk.Fixed+FixedChild
            this.preferencesLabel = new Gtk.Label();
            this.preferencesLabel.Name = "preferencesLabel";
            this.preferencesLabel.LabelProp = Mono.Unix.Catalog.GetString("<b>Preferences</b>");
            this.preferencesLabel.UseMarkup = true;
            this.preferencesLabel.UseUnderline = true;
            this.fixedLaytout.Add(this.preferencesLabel);
            Gtk.Fixed.FixedChild w12 = ((Gtk.Fixed.FixedChild)(this.fixedLaytout[this.preferencesLabel]));
            w12.X = 18;
            w12.Y = 10;
            // Container child fixedLaytout.Gtk.Fixed+FixedChild
            this.buttonSelectionBox = new Gtk.HBox();
            this.buttonSelectionBox.Name = "buttonSelectionBox";
            this.buttonSelectionBox.Spacing = 6;
            // Container child buttonSelectionBox.Gtk.Box+BoxChild
            this.cancelButton = new Gtk.Button();
            this.cancelButton.CanFocus = true;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseUnderline = true;
            // Container child cancelButton.Gtk.Container+ContainerChild
            Gtk.Alignment w13 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            w13.Name = "GtkAlignment";
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w14 = new Gtk.HBox();
            w14.Name = "GtkHBox";
            w14.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w15 = new Gtk.Image();
            w15.Name = "image50";
            w15.Pixbuf = Stetic.IconLoader.LoadIcon("gtk-cancel", 16);
            w14.Add(w15);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w17 = new Gtk.Label();
            w17.Name = "GtkLabel";
            w17.LabelProp = Mono.Unix.Catalog.GetString("Cancel");
            w17.UseUnderline = true;
            w14.Add(w17);
            w13.Add(w14);
            this.cancelButton.Add(w13);
            this.buttonSelectionBox.Add(this.cancelButton);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.buttonSelectionBox[this.cancelButton]));
            w21.Position = 0;
            w21.Expand = false;
            w21.Fill = false;
            // Container child buttonSelectionBox.Gtk.Box+BoxChild
            this.okButton = new Gtk.Button();
            this.okButton.CanFocus = true;
            this.okButton.Name = "okButton";
            this.okButton.UseUnderline = true;
            // Container child okButton.Gtk.Container+ContainerChild
            Gtk.Alignment w22 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            w22.Name = "GtkAlignment";
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w23 = new Gtk.HBox();
            w23.Name = "GtkHBox";
            w23.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w24 = new Gtk.Image();
            w24.Name = "image51";
            w24.Pixbuf = Stetic.IconLoader.LoadIcon("gtk-apply", 16);
            w23.Add(w24);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w26 = new Gtk.Label();
            w26.Name = "GtkLabel";
            w26.LabelProp = Mono.Unix.Catalog.GetString("OK");
            w26.UseUnderline = true;
            w23.Add(w26);
            w22.Add(w23);
            this.okButton.Add(w22);
            this.buttonSelectionBox.Add(this.okButton);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.buttonSelectionBox[this.okButton]));
            w30.Position = 1;
            w30.Expand = false;
            w30.Fill = false;
            this.fixedLaytout.Add(this.buttonSelectionBox);
            Gtk.Fixed.FixedChild w31 = ((Gtk.Fixed.FixedChild)(this.fixedLaytout[this.buttonSelectionBox]));
            w31.X = 263;
            w31.Y = 259;
            this.Add(this.fixedLaytout);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 396;
            this.DefaultHeight = 321;
            this.Show();
            this.cancelButton.Activated += new System.EventHandler(this.OnButton22Activated);
        }
    }
}