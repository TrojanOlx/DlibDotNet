﻿namespace DnnSemanticSegmentation
{
    
    // The names of the input image and the associated RGB label image in the PASCAL VOC 2012
    // data set.
    public sealed class ImageInfo
    {

        public string ImageFilename
        {
            get;
            set;
        }

        public string LabelFilename
        {
            get;
            set;
        }
    }

}