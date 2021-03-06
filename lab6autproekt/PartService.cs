﻿using System;
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
            var vSkLines = Part.SketchManager.CreateCornerRectangle(0, 0, 0, lengthOfMainPart / 100.0, -widthOfMainPart/100.0, 0);
            Part.ShowNamedView2("*Trimetric", 8);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            var myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, heightOfMainPart/100.0, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

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
            vSkLines = Part.SketchManager.CreateCornerRectangle(lengthOfMainPart/100.0, 0, 0, lengthOfMainPart / 100.0 - lengthOfFirst / 100, -widthOfMainPart/100.0, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, heightOfFirst/100.0, 0.06, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.490292632178182, -0.093386479456683, 0.379999999999939, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.545870787594882, -8.46928777953389E-02, 0.379999999999995, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            vSkLines = Part.SketchManager.CreateCornerRectangle(lengthOfMainPart/100.0, -8.0/100.0, 0, lengthOfMainPart/100.0 - lengthOfExtrusion/100.0, -8.0/100.0 - widthOfExtrsion/100.0, 0);

            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);

            myFeature = Part.FeatureManager.FeatureCut3(true, false, false, 1, 0, heightOfFirst/100.0, heightOfFirst/100.0, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            Part.SelectionManager.EnableContourSelection = false;
        }

        public void CreateSecond()
        {
            createPart();

            double lengthOfMainPart = 0.664753;

            double widthOfMainPart = 20 / 100.0;
            double widthOfTop = 36 / 100.0;


            var Part = swDoc;
            boolstatus = Part.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            var skSegment = Part.SketchManager.CreateLine(0, 0, 0, lengthOfMainPart, 0, 0);
            skSegment = Part.SketchManager.CreateLine(lengthOfMainPart, 0, 0, 0.533982, 0.467688, 0);
            skSegment = Part.SketchManager.CreateLine(0.533982, 0.467688, 0, 0.204875, 0.467688, 0);
            skSegment = Part.SketchManager.CreateLine(0.204875, 0.467688, 0, 0, 0, 0);
            

            Part.ShowNamedView2("*Trimetric", 8);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            var myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, widthOfMainPart, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.23187712491118, 0.229935733492981, 0.199999999999989, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            skSegment = Part.SketchManager.CreateLine(0.204875, 0.467688, 0, 0.130515, 0.297941, 0);
             skSegment = Part.SketchManager.CreateLine(0.130515, 0.297941, 0, 0.581445, 0.297941, 0);
             skSegment = Part.SketchManager.CreateLine(0.581445, 0.297941, 0, 0.533982, 0.467688, 0);
             skSegment = Part.SketchManager.CreateLine(0.533982, 0.467688, 0, 0.204875, 0.467688, 0);

             Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.16, 0.2, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.212893932278741, 0.251152242905707, 0.199999999999989, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);

            skSegment = Part.SketchManager.CreateLine(0.130515, 0.297941, 0, 0.089159, 0.203531, 0);
            skSegment = Part.SketchManager.CreateLine(0.089159, 0.203531, 0, 0.607843, 0.203531, 0);
            skSegment = Part.SketchManager.CreateLine(0.607843, 0.203531, 0, 0.581445, 0.297941, 0);
            skSegment = Part.SketchManager.CreateLine(0.581445, 0.297941, 0, 0.130515, 0.297941, 0);
             Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            myFeature = Part.FeatureManager.FeatureCut3(true, false, false, 0, 0, 0.05, 0.16, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
                Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.227931561614882, 0.115874896976422, 0.199999999999818, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);

            skSegment = Part.SketchManager.CreateLine(0.089159, 0.203531, 0, 0.051642, 0.117888, 0);
            skSegment = Part.SketchManager.CreateLine(0.051642, 0.117888, 0, 0.63179, 0.117888, 0);
            skSegment = Part.SketchManager.CreateLine(0.63179, 0.117888, 0, 0.607843, 0.203531, 0);
            skSegment = Part.SketchManager.CreateLine(0.607843, 0.203531, 0, 0.089159, 0.203531, 0);
        Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.2, 0.05, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
    Part.SelectionManager.EnableContourSelection = false;

        }

        public void CreateThird()
        {
            double lengthOfPart = 90 / 100.0;
            double widthOfFoundation = 50 / 100.0;
            double heightOfFoundation = 10 / 100.0;
            double heightOfMainPart = 48 / 100.0;

            double widthCut = 16 / 100.0;
            double heightCut = 27 / 100.0;

            double innerCircleRadius = 20 / 100.0;


            createPart();
            var Part = swDoc;
            boolstatus = Part.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            var vSkLines = Part.SketchManager.CreateCornerRectangle(0, 0, 0, lengthOfPart, -widthOfFoundation, 0);
            Part.ShowNamedView2("*Trimetric", 8);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);

            var myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, heightOfFoundation, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.232015936146354, -0.15758624030218, 9.99999999997954E-02, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.32781795007155, -0.126961580368087, 0.100000000000023, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            vSkLines = Part.SketchManager.CreateCornerRectangle(0, -4.33549869342604E-02, 0, lengthOfPart, -0.444666635416626, 0);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0, 0, 0, true, 0, null, 0);

            myFeature = Part.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, heightOfMainPart, 0.1, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);

            Part.SelectionManager.EnableContourSelection = false;

            // 2
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.68500147234262, -4.33549869343892E-02, 0.478769798118833, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.904935560563956, -0.324087696645279, 0.400307880075346, false, 0, null, 0);
            boolstatus = Part.Extension.SelectByID2("", "FACE", 0.904935560563843, -0.175038423439933, 0.411177499049977, false, 0, null, 0);
            Part.SketchManager.InsertSketch(true);
            Part.ClearSelection2(true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstToRectEntity, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);
            boolstatus = Part.Extension.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, (int)swUserPreferenceOption_e.swDetailingNoOptionSpecified, true);

            vSkLines = Part.SketchManager.CreateCornerRectangle(-0.50, -0.35, 0, -0.50 + heightCut, -0.35 + widthCut, 0);
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
           // skSegment = Part.SketchManager.CreateCircle(0.433287, 0.353515, 0, 0.380651, 0.198587, 0);
            skSegment = Part.SketchManager.CreateCircleByRadius(0.433287, 0.353515, 0, innerCircleRadius);
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
