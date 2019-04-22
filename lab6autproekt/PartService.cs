using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.swcommands;

namespace lab6autproekt
{
    public class PartService
    {
        private static PartService instance;
        SldWorks sldApp;
        ModelDoc2 swDoc;
        bool boolstatus;
        private PartService()
        {
            sldApp = new SldWorks();
            sldApp.Visible = true;
            ModelDoc model = sldApp.ActivateDoc("") as ModelDoc;
            
        }

        public static PartService GetInstance()
        {
            if (instance == null)
            {
                instance = new PartService();
            }

            return instance;
        }

        public void CreateFirst()
        {
            createPart();
            var Part = swDoc;

            double lengthOfMainPart = 65;
            double widthOfMainPart = 30;
            double heightOfMainPart = 12;

            double heightOfFirst = 26;
            double lengthOfFirst = 23;

            double lengthOfExtrusion = 9;
            double widthOfExtrsion = 11;
           
            boolstatus = Part.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            boolstatus = Part.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            Part.ClearSelection2(true);
            Part.SketchManager.InsertSketch(true);
            boolstatus = Part.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            var vSkLines = Part.SketchManager.CreateCornerRectangle(0, 0, 0, lengthOfMainPart / 100, -widthOfMainPart/100, 0);
            Part.ShowNamedView2("*Trimetric", 8);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            var myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, heightOfMainPart/100, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 5.64599078923038E-02, -0.114602306094582, 0.120000000000005, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.128015905206913, -0.151452720323176, 0.120000000000005, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            vSkLines = Part.SketchManager.CreateCornerRectangle(0, 0, 0, 8.93206935815927E-02, -0.30622217307138, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);

            myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.06, 0.12, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.331831795685154, -0.104238787657323, 0.119999999999948, false, 0, null, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            vSkLines = Part.SketchManager.CreateCornerRectangle(lengthOfMainPart/100, 0, 0, 0.422170666192329, -widthOfMainPart/100, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, heightOfFirst/100, 0.06, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.490292632178182, -0.093386479456683, 0.379999999999939, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.545870787594882, -8.46928777953389E-02, 0.379999999999995, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            vSkLines = Part.SketchManager.CreateCornerRectangle(lengthOfMainPart/100, -8.0/100, 0, lengthOfMainPart/100 - lengthOfExtrusion/100, -8.0/100 - widthOfExtrsion/100, 0);

            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);

            myFeature = Part.FeatureManager.FeatureCut3(true, false, false, 1, 0, heightOfFirst/100, heightOfFirst/100, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            Part.SelectionManager.EnableContourSelection = false;
        }

        public void CreateSecond()
        {
            createPart();

            var Part = swDoc;
            SketchManager sketchSegment = Part.SketchManager;
            FeatureManager featureHandler = Part.FeatureManager;
            
            Part.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            sketchSegment.InsertSketch(true);
            sketchSegment.CreatePoint(0, 0, 0);
            sketchSegment.CreateCornerRectangle(-0.033, -0.018, 0, 0.033, 0.018, 0);
            sketchSegment.InsertSketch(true);
            Part.ClearSelection2(true);

            Part.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            featureHandler.InsertRefPlane(8, 0.065, 0, 0, 0, 0);
            Part.ClearSelection2(true);

            Part.Extension.SelectByID2("Plane1", "PLANE", 0, 0, 0, false, 0, null, 0);
            sketchSegment.InsertSketch(true);
            sketchSegment.CreatePoint(0, 0, 0);
            sketchSegment.CreateCornerRectangle(-0.015, -0.018, 0, 0.015, 0.018, 0);
            sketchSegment.InsertSketch(true);
            Part.ClearSelection2(true);

            Part.Extension.SelectByID2("Point1@Sketch4", "EXTSKETCHPOINT", 0, 0, 0, false, 1, null, 0);
            Part.Extension.SelectByID2("Point2@Sketch5", "EXTSKETCHPOINT", 0, 0, 0, true, 1, null, 0);
            Part.Insert3DSplineCurve(false);

            Part.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 1, null, 0);
            Part.Extension.SelectByID2("Sketch2", "SKETCH", 0, 0, 0, true, 1, null, 0);
            Part.Extension.SelectByID2("Curve1", "REFERENCECURVES", 0, 0, 0, true, 4098, null, 0);
            featureHandler.InsertProtrusionBlend(false, true, false, 1, 0, 0, 1, 1, true, true, false, 0, 0, 0, true, true, true);
            Part.ClearSelection2(true);

            Part.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            sketchSegment.InsertSketch(true);
            sketchSegment.CreateCornerRectangle(-0.033, 0, 0, 0.033, 0.065 - 0.021 - 0.015 - 0.018, 0);
            sketchSegment.CreateCornerRectangle(-0.033, 0.065 - 0.021 - 0.015, 0, 0.033, 0.065 - 0.021, 0);
            featureHandler.FeatureCut3(true, false, true, 1, 0, 0.02, 0.01, false, false, false, false, 0, 0, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            Part.ClearSelection2(true);
        }

        public void CreateThird()
        {
            createPart();
            var Part = swDoc;
            boolstatus = Part.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            var vSkLines = Part.SketchManager.CreateCornerRectangle(0, 0, 0, 0.904935560563964, -0.495622221753963, 0);
            Part.ShowNamedView2("*Trimetric", 8);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);

            var myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.1, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.232015936146354, -0.15758624030218, 9.99999999997954E-02, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.32781795007155, -0.126961580368087, 0.100000000000023, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            vSkLines = Part.SketchManager.CreateCornerRectangle(0, -4.33549869342604E-02, 0, 0.904935560563964, -0.444666635416626, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);

            myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.48, 0.1, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;

            // 2
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.68500147234262, -4.33549869343892E-02, 0.478769798118833, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.904935560563956, -0.324087696645279, 0.400307880075346, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.904935560563843, -0.175038423439933, 0.411177499049977, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);

            vSkLines = Part.SketchManager.CreateCornerRectangle(-0.5035795065274, -0.349463819881812, 0, -0.221834776174125, -0.136639423738938, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);

            myFeature = Part.FeatureManager.FeatureCut3(true, false, false, 1, 0, 0.01, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);

            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.22270194244215, -0.444666635416525, 0.302036425889241, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);

            var skSegment = Part.SketchManager.CreateLine(0, 0.1, 0, 0, 0.58, 0);
            skSegment = Part.SketchManager.CreateLine(0, 0.58, 0, 0.19944, 0.58, 0);
            skSegment = Part.SketchManager.CreateLine(0.19944, 0.58, 0, 0, 0.1, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            myFeature = Part.FeatureManager.FeatureCut3(true, false, false, 1, 0, 0.02, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.714850266285968, -0.444666635416468, 0.365215287858575, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            skSegment = Part.SketchManager.CreateLine(0.904936, 0.1, 0, 0.904936, 0.58, 0);
            skSegment = Part.SketchManager.CreateLine(0.904936, 0.58, 0, 0.700949, 0.58, 0);
            skSegment = Part.SketchManager.CreateLine(0.700949, 0.58, 0, 0.904936, 0.1, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            myFeature = Part.FeatureManager.FeatureCut3(true, false, false, 1, 0, 0.02, 0.02, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.293557793122929, -0.444666635416581, 0.310968960307008, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            skSegment = Part.SketchManager.CreateCircle(0.433287, 0.353515, 0, 0.380651, 0.198587, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            myFeature = Part.FeatureManager.FeatureExtrusion2(false, false, true, 0, 0, 0.55, 0.15, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
            Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.514944876596653, -0.594666635416559, 0.391431402702604, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            skSegment = Part.SketchManager.CreateCircle(0.433287, 0.353515, 0, 0.406353, 0.245981, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            myFeature = Part.FeatureManager.FeatureCut3(true, false, false, 0, 0, 0.7, 0.55, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            Part.SelectionManager.EnableContourSelection = false;

        }

        private void createPart()
        {
            swDoc = null;
            int longstatus = 0;
            swDoc = ((ModelDoc2)(sldApp.NewDocument("C:\\ProgramData\\SOLIDWORKS\\SOLIDWORKS 2016\\templates\\Part.prtdot", 0, 0, 0)));
            sldApp.ActivateDoc2("Part1", false, ref longstatus);
            swDoc = ((ModelDoc2)(sldApp.ActiveDoc));
            ModelView myModeview = null;
            myModeview = ((ModelView)(swDoc.ActiveView));
            myModeview.FrameState = ((int)(swWindowState_e.swWindowMaximized));
            boolstatus = false;
        }
    }
}
