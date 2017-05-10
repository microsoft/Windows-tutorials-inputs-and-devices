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

using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// Begin "Step 2: Basic inking with InkCanvas"
////using directives for inking functionality.
//using Windows.UI.Input.Inking;
//using Windows.UI.Input.Inking.Analysis;
//using Windows.UI.Xaml.Shapes;
//using Windows.Storage.Streams;
// End "Step 2: Basic inking with InkCanvas"

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GettingStarted_Ink
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Begin "Step 5: Handwriting recognition"
        //InkAnalyzer analyzerText = new InkAnalyzer();
        //IReadOnlyList<InkStroke> strokesText = null;
        //InkAnalysisResult resultText = null;
        //IReadOnlyList<IInkAnalysisNode> words = null;
        // End "Step 5: Handwriting recognition"

        // Begin "Step 6: Shape recognition"
        //InkAnalyzer analyzerShape = new InkAnalyzer();
        //IReadOnlyList<InkStroke> strokesShape = null;
        //InkAnalysisResult resultShape = null;
        // End "Step 6: Shape recognition"

        public MainPage()
        {
            this.InitializeComponent();

            // Begin "Step 3: Inking with touch and mouse"
            //inkCanvas.InkPresenter.InputDeviceTypes =
            //    Windows.UI.Core.CoreInputDeviceTypes.Mouse |
            //    Windows.UI.Core.CoreInputDeviceTypes.Touch |
            //    Windows.UI.Core.CoreInputDeviceTypes.Pen;
            // End "Step 3: Inking with touch and mouse"

        }

        // Begin "Step 5: Handwriting recognition"
        //private async void recognizeText_ClickAsync(object sender, RoutedEventArgs e)
        //{
        //    strokesText = inkCanvas.InkPresenter.StrokeContainer.GetStrokes();
        //    // Ensure an ink stroke is present.
        //    if (strokesText.Count > 0)
        //    {
        //        analyzerText.AddDataForStrokes(strokesText);

        //        // Force analyzer to process strokes as handwriting.
        //        foreach (var stroke in strokesText)
        //        {
        //            analyzerText.SetStrokeDataKind(stroke.Id, InkAnalysisStrokeKind.Writing);
        //        }

        //        // Clear recognition results string.
        //        recognitionResult.Text = "";

        //        resultText = await analyzerText.AnalyzeAsync();

        //        if (resultText.Status == InkAnalysisStatus.Updated)
        //        {
        //            var text = analyzerText.AnalysisRoot.RecognizedText;
        //            words = analyzerText.AnalysisRoot.FindNodes(InkAnalysisNodeKind.InkWord);
        //            foreach (var word in words)
        //            {
        //                InkAnalysisInkWord concreteWord = (InkAnalysisInkWord)word;
        //                foreach (string s in concreteWord.TextAlternates)
        //                {
        //                    recognitionResult.Text += s + " ";
        //                }
        //                recognitionResult.Text += " / ";
        //            }
        //        }
        //        analyzerText.ClearDataForAllStrokes();
        //    }
        //}
        // End "Step 5: Handwriting recognition"

        // Begin "Step 6: Shape recognition"
        //private async void recognizeShape_ClickAsync(object sender, RoutedEventArgs e)
        //{
        //    strokesShape = inkCanvas.InkPresenter.StrokeContainer.GetStrokes();

        //    if (strokesShape.Count > 0)
        //    {
        //        analyzerShape.AddDataForStrokes(strokesShape);

        //        resultShape = await analyzerShape.AnalyzeAsync();

        //        if (resultShape.Status == InkAnalysisStatus.Updated)
        //        {
        //            var drawings = analyzerShape.AnalysisRoot.FindNodes(InkAnalysisNodeKind.InkDrawing);

        //            foreach (var drawing in drawings)
        //            {
        //                var shape = (InkAnalysisInkDrawing)drawing;
        //                if (shape.DrawingKind == InkAnalysisDrawingKind.Drawing)
        //                {
        //                    // Catch and process unsupported shapes (lines and so on) here.
        //                }
        //                else
        //                {
        //                    // Process recognized shapes here.
        //                    if (shape.DrawingKind == InkAnalysisDrawingKind.Circle || shape.DrawingKind == InkAnalysisDrawingKind.Ellipse)
        //                    {
        //                        DrawEllipse(shape);
        //                    }
        //                    else
        //                    {
        //                        DrawPolygon(shape);
        //                    }
        //                    foreach (var strokeId in shape.GetStrokeIds())
        //                    {
        //                        var stroke = inkCanvas.InkPresenter.StrokeContainer.GetStrokeById(strokeId);
        //                        stroke.Selected = true;
        //                    }
        //                }
        //                analyzerShape.RemoveDataForStrokes(shape.GetStrokeIds());
        //            }
        //            inkCanvas.InkPresenter.StrokeContainer.DeleteSelected();
        //        }
        //    }
        //}

        //private void DrawEllipse(InkAnalysisInkDrawing shape)
        //{
        //    var points = shape.Points;
        //    Ellipse ellipse = new Ellipse();
        //    ellipse.Width = Math.Sqrt((points[0].X - points[2].X) * (points[0].X - points[2].X) +
        //         (points[0].Y - points[2].Y) * (points[0].Y - points[2].Y));
        //    ellipse.Height = Math.Sqrt((points[1].X - points[3].X) * (points[1].X - points[3].X) +
        //         (points[1].Y - points[3].Y) * (points[1].Y - points[3].Y));

        //    var rotAngle = Math.Atan2(points[2].Y - points[0].Y, points[2].X - points[0].X);
        //    RotateTransform rotateTransform = new RotateTransform();
        //    rotateTransform.Angle = rotAngle * 180 / Math.PI;
        //    rotateTransform.CenterX = ellipse.Width / 2.0;
        //    rotateTransform.CenterY = ellipse.Height / 2.0;

        //    TranslateTransform translateTransform = new TranslateTransform();
        //    translateTransform.X = shape.Center.X - ellipse.Width / 2.0;
        //    translateTransform.Y = shape.Center.Y - ellipse.Height / 2.0;

        //    TransformGroup transformGroup = new TransformGroup();
        //    transformGroup.Children.Add(rotateTransform);
        //    transformGroup.Children.Add(translateTransform);
        //    ellipse.RenderTransform = transformGroup;

        //    var brush = new SolidColorBrush(Windows.UI.ColorHelper.FromArgb(255, 0, 0, 255));
        //    ellipse.Stroke = brush;
        //    ellipse.StrokeThickness = 2;
        //    canvas.Children.Add(ellipse);
        //}

        //private void DrawPolygon(InkAnalysisInkDrawing shape)
        //{
        //    var points = shape.Points;
        //    Polygon polygon = new Polygon();

        //    foreach (var point in points)
        //    {
        //        polygon.Points.Add(point);
        //    }

        //    var brush = new SolidColorBrush(Windows.UI.ColorHelper.FromArgb(255, 0, 0, 255));
        //    polygon.Stroke = brush;
        //    polygon.StrokeThickness = 2;
        //    canvas.Children.Add(polygon);
        //}
        // End "Step 6: Shape recognition"

        // Begin "Step 7: Saving and loading ink"
        //private async void buttonSave_ClickAsync(object sender, RoutedEventArgs e)
        //{
        //    // Get all strokes on the InkCanvas.
        //    IReadOnlyList<InkStroke> currentStrokes = inkCanvas.InkPresenter.StrokeContainer.GetStrokes();

        //    if (currentStrokes.Count > 0)
        //    {
        //        // Use a file picker to identify ink file.
        //        Windows.Storage.Pickers.FileSavePicker savePicker =
        //            new Windows.Storage.Pickers.FileSavePicker();
        //        savePicker.SuggestedStartLocation =
        //            Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
        //        savePicker.FileTypeChoices.Add(
        //            "GIF with embedded ISF",
        //            new List<string>() { ".gif" });
        //        savePicker.DefaultFileExtension = ".gif";
        //        savePicker.SuggestedFileName = "InkSample";

        //        // Show the file picker.
        //        Windows.Storage.StorageFile file =
        //            await savePicker.PickSaveFileAsync();
        //        // When selected, picker returns a reference to the file.
        //        if (file != null)
        //        {
        //            // Prevent updates to the file until updates are 
        //            // finalized with call to CompleteUpdatesAsync.
        //            Windows.Storage.CachedFileManager.DeferUpdates(file);
        //            // Open a file stream for writing.
        //            IRandomAccessStream stream = await file.OpenAsync(Windows.Storage.FileAccessMode.ReadWrite);
        //            // Write the ink strokes to the output stream.
        //            using (IOutputStream outputStream = stream.GetOutputStreamAt(0))
        //            {
        //                await inkCanvas.InkPresenter.StrokeContainer.SaveAsync(outputStream);
        //                await outputStream.FlushAsync();
        //            }
        //            stream.Dispose();

        //            // Finalize write so other apps can update file.
        //            Windows.Storage.Provider.FileUpdateStatus status =
        //                await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(file);

        //            if (status == Windows.Storage.Provider.FileUpdateStatus.Complete)
        //            {
        //                // File saved.
        //            }
        //            else
        //            {
        //                // File couldn't be saved.
        //            }
        //        }
        //        // User selects Cancel and picker returns null.
        //        else
        //        {
        //            // Operation cancelled.
        //        }
        //    }
        //}

        //private async void buttonLoad_ClickAsync(object sender, RoutedEventArgs e)
        //{
        //    // Use a file picker to identify ink file.
        //    Windows.Storage.Pickers.FileOpenPicker openPicker =
        //        new Windows.Storage.Pickers.FileOpenPicker();
        //    openPicker.SuggestedStartLocation =
        //        Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
        //    openPicker.FileTypeFilter.Add(".gif");
        //    // Show the file picker.
        //    Windows.Storage.StorageFile file = await openPicker.PickSingleFileAsync();
        //    // When selected, picker returns a reference to the file.
        //    if (file != null)
        //    {
        //        // Open a file stream for reading.
        //        IRandomAccessStream stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
        //        // Read from file.
        //        using (var inputStream = stream.GetInputStreamAt(0))
        //        {
        //            await inkCanvas.InkPresenter.StrokeContainer.LoadAsync(inputStream);
        //        }
        //        stream.Dispose();
        //    }
        //    // User selects Cancel and picker returns null.
        //    else
        //    {
        //        // Operation cancelled.
        //    }
        //}
        // End "Step 7: Saving and loading ink"
    }
}
