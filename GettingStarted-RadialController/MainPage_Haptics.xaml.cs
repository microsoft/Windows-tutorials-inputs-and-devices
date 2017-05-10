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
using System.Collections.Generic;
using System;

// Using directives for RadialController functionality.
using Windows.UI.Input;

// Begin "Step 6: Haptics customization"
//using Windows.Devices.Haptics;
// End "Step 6: Haptics customization"

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GettingStarted_RadialController
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage_Haptics : Page
    {
        public MainPage_Haptics()
        {
            this.InitializeComponent();

            InitializeSampleButton.Click += (sender, args) =>
            { InitializeSample(sender, args); };
        }

        private RadialController radialController;
        private RadialControllerConfiguration radialControllerConfig;
        private RadialControllerMenuItem radialControllerMenuItem;

        // Set up the app UI and RadialController.
        private void InitializeSample(object sender, RoutedEventArgs e)
        {
            ResetControllerButton.IsEnabled = true;
            AddRemoveToggleButton.IsEnabled = true;

            ResetControllerButton.Click += (resetsender, args) =>
            { ResetController(resetsender, args); };
            AddRemoveToggleButton.Click += (togglesender, args) =>
            { AddRemoveItem(togglesender, args); };

            InitializeController(sender, e);
        }

        // Configure RadialController menu and custom tool.
        private void InitializeController(object sender, RoutedEventArgs args)
        {
            // Create a reference to the RadialController.
            radialController = RadialController.CreateForCurrentView();
            // Set rotation resolution to 1 degree of sensitivity.
            radialController.RotationResolutionInDegrees = 1;

            // Create the custom menu items.
            // Here, we use a font glyph for our custom tool.
            radialControllerMenuItem =
                RadialControllerMenuItem.CreateFromFontGlyph("SampleTool", "\xE1E3", "Segoe MDL2 Assets");

            // Add the item to the RadialController menu.
            radialController.Menu.Items.Add(radialControllerMenuItem);

            // Remove built-in tools to declutter the menu.
            // NOTE: The Surface Dial menu must have at least one menu item. 
            // If all built-in tools are removed before you add a custom 
            // tool, the default tools are restored and your tool is appended 
            // to the default collection.
            radialControllerConfig =
                RadialControllerConfiguration.GetForCurrentView();
            radialControllerConfig.SetDefaultMenuItems(
                new RadialControllerSystemMenuItemKind[] { });

            // Declare input handlers for the RadialController.
            // NOTE: These events are only fired when a custom tool is active.
            radialController.ButtonClicked += (clicksender, clickargs) =>
            { RadialController_ButtonClicked(clicksender, clickargs); };
            radialController.RotationChanged += (rotationsender, rotationargs) =>
            { RadialController_RotationChanged(rotationsender, rotationargs); };

            // Begin "Step 6: Haptics customization"
            //radialController.ControlAcquired += (hapticssender, hapticsargs) =>
            //{ RadialController_ControlAcquired(hapticssender, hapticsargs); };
            // End "Step 6: Haptics customization"
        }

        // Begin "Step 6: Haptics customization"
        //private void RadialController_ControlAcquired(
        //    RadialController rc_sender,
        //    RadialControllerControlAcquiredEventArgs args)
        //{
        //    // Turn off default haptic feedback.
        //    radialController.UseAutomaticHapticFeedback = false;

        //    SimpleHapticsController hapticsController =
        //        args.SimpleHapticsController;

        //    // Enumerate haptic support.
        //    IReadOnlyCollection<SimpleHapticsControllerFeedback> supportedFeedback =
        //        hapticsController.SupportedFeedback;

        //    foreach (SimpleHapticsControllerFeedback feedback in supportedFeedback)
        //    {
        //        if (feedback.Waveform == KnownSimpleHapticsControllerWaveforms.BuzzContinuous)
        //        {
        //            CBBuzzContinuous.IsEnabled = true;
        //            CBBuzzContinuous.IsChecked = true;
        //        }
        //        else if (feedback.Waveform == KnownSimpleHapticsControllerWaveforms.Click)
        //        {
        //            CBClick.IsEnabled = true;
        //            CBClick.IsChecked = true;
        //        }
        //        else if (feedback.Waveform == KnownSimpleHapticsControllerWaveforms.Press)
        //        {
        //            CBPress.IsEnabled = true;
        //            CBPress.IsChecked = true;
        //        }
        //        else if (feedback.Waveform == KnownSimpleHapticsControllerWaveforms.Release)
        //        {
        //            CBRelease.IsEnabled = true;
        //            CBRelease.IsChecked = true;
        //        }
        //        else if (feedback.Waveform == KnownSimpleHapticsControllerWaveforms.RumbleContinuous)
        //        {
        //            CBRumbleContinuous.IsEnabled = true;
        //            CBRumbleContinuous.IsChecked = true;
        //        }
        //    }

        //    if (hapticsController?.IsIntensitySupported == true)
        //    {
        //        CBIntensity.IsEnabled = true;
        //        CBIntensity.IsChecked = true;
        //    }
        //    if (hapticsController?.IsPlayCountSupported == true)
        //    {
        //        CBPlayCount.IsEnabled = true;
        //        CBPlayCount.IsChecked = true;
        //    }
        //    if (hapticsController?.IsPlayDurationSupported == true)
        //    {
        //        CBPlayDuration.IsEnabled = true;
        //        CBPlayDuration.IsChecked = true;
        //    }
        //    if (hapticsController?.IsReplayPauseIntervalSupported == true)
        //    {
        //        CBReplayPauseInterval.IsEnabled = true;
        //        CBReplayPauseInterval.IsChecked = true;
        //    }
        //}
        // End "Step 6: Haptics customization"

        // Connect wheel device rotation to slider control.
        private void RadialController_RotationChanged(
            object sender, RadialControllerRotationChangedEventArgs args)
        {
            if (RotationSlider.Value + args.RotationDeltaInDegrees >= RotationSlider.Maximum)
            {
                RotationSlider.Value = RotationSlider.Maximum;
            }
            else if (RotationSlider.Value + args.RotationDeltaInDegrees < RotationSlider.Minimum)
            {
                RotationSlider.Value = RotationSlider.Minimum;
            }
            else
            {
                RotationSlider.Value += args.RotationDeltaInDegrees;
            }

            // Begin "Step 6: Haptics customization"
            //if (ClickToggle.IsOn &&
            //    (RotationSlider.Value > RotationSlider.Minimum) &&
            //    (RotationSlider.Value < RotationSlider.Maximum))
            //{
            //    SimpleHapticsControllerFeedback waveform =
            //        FindWaveform(args.SimpleHapticsController,
            //        KnownSimpleHapticsControllerWaveforms.BuzzContinuous);
            //    if (waveform != null)
            //    {
            //        args.SimpleHapticsController.SendHapticFeedback(waveform);
            //    }
            //}
            // End "Step 6: Haptics customization"
        }

        private void RadialController_ButtonClicked(
            object sender, RadialControllerButtonClickedEventArgs args)
        {
            ClickToggle.IsOn = !ClickToggle.IsOn;

            // Begin "Step 6: Haptics customization"
            //if (RotationSlider?.Value > 0)
            //{
            //    SimpleHapticsControllerFeedback waveform =
            //        FindWaveform(args.SimpleHapticsController,
            //        KnownSimpleHapticsControllerWaveforms.Click);

            //    if (waveform != null)
            //    {
            //        args.SimpleHapticsController.SendHapticFeedbackForPlayCount(
            //            waveform, 1.0,
            //            (int)RotationSlider.Value,
            //            TimeSpan.Parse("1"));
            //    }
            //}
            // End "Step 6: Haptics customization"
        }

        // Begin "Step 6: Haptics customization"
        // Get the requested waveform.
        //private SimpleHapticsControllerFeedback FindWaveform(
        //    SimpleHapticsController hapticsController,
        //    ushort waveform)
        //{
        //    foreach (var hapticInfo in hapticsController.SupportedFeedback)
        //    {
        //        if (hapticInfo.Waveform == waveform)
        //        {
        //            return hapticInfo;
        //        }
        //    }
        //    return null;
        //}
        // End "Step 6: Haptics customization"

        // Add or remove the custom tool.
        private void AddRemoveItem(object sender, RoutedEventArgs args)
        {
            if (AddRemoveToggleButton?.IsChecked == true)
            {
                AddRemoveToggleButton.Content = "Remove item";
                if (!radialController.Menu.Items.Contains(radialControllerMenuItem))
                {
                    radialController.Menu.Items.Add(radialControllerMenuItem);
                }
            }
            else if (AddRemoveToggleButton?.IsChecked == false)
            {
                AddRemoveToggleButton.Content = "Add item";
                if (radialController.Menu.Items.Contains(radialControllerMenuItem))
                {
                    radialController.Menu.Items.Remove(radialControllerMenuItem);
                    // Attempts to select and activate the previously selected tool.
                    // NOTE: Does not differentiate between built-in and custom tools.
                    radialController.Menu.TrySelectPreviouslySelectedMenuItem();
                }
            }
        }

        // Reset the RadialController to initial state.
        private void ResetController(object sender, RoutedEventArgs arg)
        {
            if (!radialController.Menu.Items.Contains(radialControllerMenuItem))
            {
                radialController.Menu.Items.Add(radialControllerMenuItem);
            }
            AddRemoveToggleButton.Content = "Remove item";
            AddRemoveToggleButton.IsChecked = true;
            radialControllerConfig.SetDefaultMenuItems(
                new RadialControllerSystemMenuItemKind[] { });
        }
    }
}
