//  ---------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// 
//  The MIT License (MIT)
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//  ---------------------------------------------------------------------------------

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Begin "Step 4: Customize the basic RadialController menu"
//// Using directives for RadialController functionality.
//using Windows.UI.Input;
// End "Step 4: Customize the basic RadialController menu"

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GettingStarted_RadialController
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage_Basic : Page
    {
        public MainPage_Basic()
        {
            this.InitializeComponent();

            // Begin "Step 4: Customize the basic RadialController menu"
            //InitializeSampleButton.Click += (sender, args) =>
            //{ InitializeSample(sender, args); };
            // End "Step 4: Customize the basic RadialController menu"

        }

        // Begin "Step 4: Customize the basic RadialController menu"
        //private RadialController radialController;
        //private RadialControllerConfiguration radialControllerConfig;
        //private RadialControllerMenuItem radialControllerMenuItem;

        //// Set up the app UI and RadialController.
        //private void InitializeSample(object sender, RoutedEventArgs e)
        //{
        //    ResetControllerButton.IsEnabled = true;
        //    AddRemoveToggleButton.IsEnabled = true;

        //    ResetControllerButton.Click += (resetsender, args) =>
        //    { ResetController(resetsender, args); };
        //    AddRemoveToggleButton.Click += (togglesender, args) =>
        //    { AddRemoveItem(togglesender, args); };

        //    InitializeController(sender, e);
        //}

        //// Configure RadialController menu and custom tool.
        //private void InitializeController(object sender, RoutedEventArgs args)
        //{
        //    // Create a reference to the RadialController.
        //    radialController = RadialController.CreateForCurrentView();
        //    // Set rotation resolution to 1 degree of sensitivity.
        //    radialController.RotationResolutionInDegrees = 1;

        //    // Create the custom menu items.
        //    // Here, we use a font glyph for our custom tool.
        //    radialControllerMenuItem =
        //        RadialControllerMenuItem.CreateFromFontGlyph("SampleTool", "\xE1E3", "Segoe MDL2 Assets");

        //    // Add the item to the RadialController menu.
        //    radialController.Menu.Items.Add(radialControllerMenuItem);

        //    // Remove built-in tools to declutter the menu.
        //    // NOTE: The Surface Dial menu must have at least one menu item. 
        //    // If all built-in tools are removed before you add a custom 
        //    // tool, the default tools are restored and your tool is appended 
        //    // to the default collection.
        //    radialControllerConfig =
        //        RadialControllerConfiguration.GetForCurrentView();
        //    radialControllerConfig.SetDefaultMenuItems(
        //        new RadialControllerSystemMenuItemKind[] { });

        //    // Declare input handlers for the RadialController.
        //    // NOTE: These events are only fired when a custom tool is active.
        //    radialController.ButtonClicked += (clicksender, clickargs) =>
        //    { RadialController_ButtonClicked(clicksender, clickargs); };
        //    radialController.RotationChanged += (rotationsender, rotationargs) =>
        //    { RadialController_RotationChanged(rotationsender, rotationargs); };
        //}

        //// Connect wheel device rotation to slider control.
        //private void RadialController_RotationChanged(object sender, RadialControllerRotationChangedEventArgs args)
        //{
        //    if (RotationSlider.Value + args.RotationDeltaInDegrees >= RotationSlider.Maximum)
        //    {
        //        RotationSlider.Value = RotationSlider.Maximum;
        //    }
        //    else if (RotationSlider.Value + args.RotationDeltaInDegrees < RotationSlider.Minimum)
        //    {
        //        RotationSlider.Value = RotationSlider.Minimum;
        //    }
        //    else
        //    {
        //        RotationSlider.Value += args.RotationDeltaInDegrees;
        //    }
        //}

        //// Connect wheel device click to toggle switch control.
        //private void RadialController_ButtonClicked(object sender, RadialControllerButtonClickedEventArgs args)
        //{
        //    ClickToggle.IsOn = !ClickToggle.IsOn;
        //}
        // End "Step 4: Customize the basic RadialController menu"

        // Add or remove the custom tool.
        private void AddRemoveItem(object sender, RoutedEventArgs args)
        {
            // Begin "Step 5: Configure menu at runtime"
            //if (AddRemoveToggleButton?.IsChecked == true)
            //{
            //    AddRemoveToggleButton.Content = "Remove item";
            //    if (!radialController.Menu.Items.Contains(radialControllerMenuItem))
            //    {
            //        radialController.Menu.Items.Add(radialControllerMenuItem);
            //    }
            //}
            //else if (AddRemoveToggleButton?.IsChecked == false)
            //{
            //    AddRemoveToggleButton.Content = "Add item";
            //    if (radialController.Menu.Items.Contains(radialControllerMenuItem))
            //    {
            //        radialController.Menu.Items.Remove(radialControllerMenuItem);
            //        // Attempts to select and activate the previously selected tool.
            //        // NOTE: Does not differentiate between built-in and custom tools.
            //        radialController.Menu.TrySelectPreviouslySelectedMenuItem();
            //    }
            //}
            // End "Step 5: Configure menu at runtime"
        }

        // Reset the RadialController to initial state.
        private void ResetController(object sender, RoutedEventArgs arg)
        {
            // Begin "Step 5: Configure menu at runtime"
            //if (!radialController.Menu.Items.Contains(radialControllerMenuItem))
            //{
            //    radialController.Menu.Items.Add(radialControllerMenuItem);
            //}
            //AddRemoveToggleButton.Content = "Remove item";
            //AddRemoveToggleButton.IsChecked = true;
            //radialControllerConfig.SetDefaultMenuItems(
            //    new RadialControllerSystemMenuItemKind[] { });
            // End "Step 5: Configure menu at runtime"
        }
    }
}
