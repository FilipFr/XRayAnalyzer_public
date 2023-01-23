using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Reflection;
using System.ComponentModel;

namespace XRayAnalyzer.Objects
{
    public static class StringsResource
    {
        //general
        public static string Confirm { get; private set; } = "";
        public static string Cancel { get; private set; } = "";
        public static string From { get; private set; } = "";
        public static string To { get; private set; } = "";
        public static string LivePreview { get; private set; } = "";
        public static string Preview { get; private set; } = "";

        //table headers
        public static string TableHeaderChannel { get; private set; } = "";
        public static string TableHeaderEnergy { get; private set; } = "";
        public static string TableHeaderValue { get; private set; } = "";
        public static string TableHeaderNetArea { get; private set; } = "";
        public static string TableHeaderGrossArea { get; private set; } = "";
        public static string TableHeaderElement { get; private set; } = "";
        public static string TableHeaderProtonNumber { get; private set; } = "";
        public static string TableHeaderLine { get; private set; } = "";
        public static string TableHeaderAmount { get; private set; } = "";
        public static string TableHeaderSymbol { get; private set; } = "";
        public static string TableHeaderName { get; private set; } = "";
        public static string TableHeaderDetector { get; private set; } = "";
        public static string TableHeaderTotalAttenuation { get; private set; } = "";
        public static string TableHeaderTotalPhotofraction { get; private set; } = "";
        public static string TableHeaderWindow { get; private set; } = "";
        public static string TableHeaderProbability { get; private set; } = "";
        public static string TableHeaderJumpRatio { get; private set; } = "";
        public static string TableHeaderUnit { get; private set; } = "";
        public static string TableHeaderMassAttenuationCoefficient { get; private set; } = "";
        public static string TableHeaderMassAbsorptionCoefficient { get; private set; } = "";


        //menu
        public static string MenuFile { get; private set; } = "";
        public static string SaveFile { get; private set; } = "";

        //language menu
        public static string MenuLanguage { get; private set; } = "";
        public static string LanguageSK { get; private set; } = "";
        public static string LanguageEN { get; private set; } = "";

        //spectrum processing and analysis menu
        public static string MenuView { get; private set; } = "";
        public static string SpectrumProcessingView { get; private set; } = "";
        public static string AnalysisView { get; private set; } = "";

        //data menu
        public static string DataView { get; private set; } = "";
        public static string ElementLineDataView { get; private set; } = "";
        public static string DetectorEfficiencyDataView { get; private set; } = "";
        public static string FluorescentYieldDataView { get; private set; } = "";
        public static string JumpRatioDataView { get; private set; } = "";
        public static string XrayMassCoefficientDataView { get; private set; } = "";

        //about
        public static string MenuAbout { get; private set; } = "";
        public static string MenuAboutContent { get; private set; } = "";

        //spectrum processing operations
        public static string LoadFileOperationName { get; private set; } = "";
        public static string EditPeaksOperationName { get; private set; } = "";
        public static string CalibrateDataOperationName { get; private set; } = "";
        public static string BackgroundRemovalOperationName { get; private set; } = "";
        public static string SumPeaksRemovalOperationName { get; private set; } = "";
        public static string SmoothingOperationName { get; private set; } = "";
        public static string NetExtractionOperationName { get; private set; } = "";

        //analysis operations
        public static string QualitativeOperationName { get; private set; } = "";
        public static string QuantitativeOperationName { get; private set; } = "";

        //filter operations
        public static string EqualFilterOperation { get; private set; } = "";
        public static string RangeFilterOperation { get; private set; } = "";
        public static string ContainsFilterOperation { get; private set; } = "";
        public static string StartsWithFilterOperation { get; private set; } = "";
        public static string EndsWithFilterOperation { get; private set; } = "";

        //plot operations
        public static string YAxisOptionsLabel { get; private set; } = "";
        public static string XAxisOptionsLabel { get; private set; } = "";
        public static string YAxisOptionLinear { get; private set; } = "";
        public static string YAxisOptionLogarithmic { get; private set; } = "";
        public static string XAxisLabelChannel { get; private set; } = "";
        public static string XAxisLabelEnergy { get; private set; } = "";
        public static string YAxisLabel { get; private set; } = "";

        //load data view
        public static string LoadFileViewSelectFile { get; private set; } = "";
        public static string LoadFileViewCurrentFileLabel { get; private set; } = "";
        public static string LoadFileViewGainLabel { get; private set; } = "";
        public static string LoadFileViewPeakCountLabel { get; private set; } = "";
        public static string LoadFileViewIsCalibratedLabel { get; private set; } = "";
        public static string LoadFileViewIsBackgroundRemovedLabel { get; private set; } = "";
        public static string LoadFileViewIsSumPeaksRemovedLabel { get; private set; } = "";
        public static string LoadFileViewIsSmoothedLabel { get; private set; } = "";
        public static string LoadFileViewIsNetAreaExtractedLabel { get; private set; } = "";
        public static string LoadFileViewIsAnalyzedQualitativelyLabel { get; private set; } = "";
        public static string LoadFileViewIsAnalyzedQuantitativelyLabel { get; private set; } = "";

        //peak info labels
        public static string PeakInfoHeader { get; private set; } = "";
        public static string PeakInfoValue { get; private set; } = "";
        public static string PeakInfoEnergy { get; private set; } = "";
        public static string PeakInfoChannel { get; private set; } = "";
        public static string PeakInfoLeftBoundaryEnergy { get; private set; } = "";
        public static string PeakInfoRightBoundaryEnergy { get; private set; } = "";
        public static string PeakInfoLeftBoundaryChannel { get; private set; } = "";
        public static string PeakInfoRightBoundaryChannel { get; private set; } = "";
        public static string PeakInfoGrossArea { get; private set; } = "";
        public static string PeakInfoNetArea { get; private set; } = "";
        public static string PeakInfoQuantity { get; private set; } = "";

        //edit peaks view
        public static string EditPeaksViewSelect { get; private set; } = "";
        public static string EditPeaksViewAdd { get; private set; } = "";
        public static string EditPeaksViewEditBase { get; private set; } = "";
        public static string EditPeaksViewRemove{ get; private set; } = "";
        public static string EditPeaksViewSearch { get; private set; } = "";
        public static string EditPeaksViewMinimalDistance { get; private set; } = "";
        public static string EditPeaksViewProminence { get; private set; } = "";
        public static string EditPeaksViewChannelBorders { get; private set; } = "";
        public static string EditPeaksViewMaximumChannelWidth { get; private set; } = "";

        //calibration view
        public static string CalibrationViewPeakChannel { get; private set; } = "";
        public static string CalibrationViewElement { get; private set; } = "";
        public static string CalibrationViewLine { get; private set; } = "";
        public static string CalibrationViewEnergy { get; private set; } = "";
        public static string CalibrationViewAddPeak { get; private set; } = "";
        public static string CalibrationViewRemoveSelectedPoint { get; private set; } = "";
        public static string CalibrationViewCancel { get; private set; } = "";
        public static string CalibrationViewTableHeaderChannel { get; private set; } = "";
        public static string CalibrationViewTableHeaderElement { get; private set; } = "";
        public static string CalibrationViewTableHeaderLine { get; private set; } = "";
        public static string CalibrationViewTableHeaderEnergy { get; private set; } = "";
        public static string CalibrationViewCalibrate { get; private set; } = "";
        public static string CalibrationViewSlope { get; private set; } = "";
        public static string CalibrationViewIntercept { get; private set; } = "";
        public static string CalibrationViewPearsonCorrelationCoefficient { get; private set; } = "";
        public static string CalibrationViewStandardErrorGradient { get; private set; } = "";
        public static string CalibrationViewStandardErrorIntercept { get; private set; } = "";
        public static string CalibrationErrorMessageChannelExists { get; private set; } = "";
        public static string CalibrationErrorMessageInvalidChannel { get; private set; } = "";
        public static string CalibrationErrorMessageInvalidEnergy { get; private set; } = "";

        //background removal view
        public static string BackgroundRemovalViewSmoothness { get; private set; } = "";
        public static string BackgroundRemovalViewIterations { get; private set; } = "";

        //summation peaks removal view
        public static string SumPeaksRemovalViewDetect { get; private set; } = "";

        //net area extraction view
        public static string NetExtractionViewExtract { get; private set; } = "";

        //analysis
        public static string AnalysisRun { get; private set; } = "";
        public static string AnalysisRunning { get; private set; } = "";

        //qualitative analysis
        public static string QualitativeAnalysisPossibleMatches { get; private set; } = "";
        public static string QualitativeAnalysisBestMatches { get; private set; } = "";

        //quantitative analysis
        public static string QuantitativeAnalysisDetector { get; private set; } = "";
        public static string QuantitativeAnalysisPrimaryElement { get; private set; } = "";
        public static string QuantitativeAnalysisAngleTubeSample { get; private set; } = "";
        public static string QuantitativeAnalysisAngleDetectorSample { get; private set; } = "";
        public static string QuantitativeAnalysisElementsDetected { get; private set; } = "";

        //data filter
        public static string DataFilterColumnName { get; private set; } = "";
        public static string DataFilterOperation { get; private set; } = "";
        public static string DataFilterValue { get; private set; } = "";
        public static string DataFilterSubmit { get; private set; } = "";


        public static void ChangeLanguage(string language)
        {
            foreach (string file in Directory.EnumerateFiles(Properties.Settings.Default.LanguagePath, "*.json"))
            {
                string fileLanguage = Path.GetFileNameWithoutExtension(file);
                if (fileLanguage.ToLower() == language.ToLower())
                {
                    Dictionary<string, string>? contents = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(file));

                    List<PropertyInfo> propertiesInfo = typeof(StringsResource).GetProperties().ToList();
                    foreach (PropertyInfo propertyInfo in propertiesInfo)
                    {
                        propertyInfo.SetValue(null, contents?.GetValueOrDefault(propertyInfo.Name));
                        OnStaticPropertyChanged(propertyInfo.Name);
                    }

                    Properties.Settings.Default.Language = language;
                    Properties.Settings.Default.Save();

                    break;
                }
            }

        }

        public static event PropertyChangedEventHandler? StaticPropertyChanged;

        private static void OnStaticPropertyChanged(string? propertyName = null)
        {
            StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propertyName));
        }

        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
        {
            return dictionary.TryGetValue(key, out var value) ? value : defaultValue;
        }
    }
}
