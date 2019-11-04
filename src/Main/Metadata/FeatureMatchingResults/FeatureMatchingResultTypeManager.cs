using System;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.FeatureMatchingResults
{

    [Flags]
    public enum FeatureMatchingResultType
    {
        Unknown = 1,
        Success = 2,
        Ambiguous = 4,
        BrokenTie = 8,
        Composite = 16,
        Nearby = 32,
        LessThanMinimumScore = 64,
        InvalidFeature = 128,
        NullFeature = 256,
        Unmatchable = 512,
        ExceptionOccurred = 1024,
    }

    public enum FeatureMatchingGeographyType
    {
        Unknown,
        GPS,
        BuildingCentroid,
        Building,
        BuildingDoor,
        Parcel,
        StreetSegment,
        StreetIntersection,
        StreetCentroid,
        USPSZipPlus5,
        USPSZipPlus4,
        USPSZipPlus3,
        USPSZipPlus2,
        USPSZipPlus1,
        USPSZip,
        ZCTAPlus5,
        ZCTAPlus4,
        ZCTAPlus3,
        ZCTAPlus2,
        ZCTAPlus1,
        ZCTA,
        City,
        ConsolidatedCity,
        MinorCivilDivision,
        CountySubRegion,
        County,
        State,
        Country,
        Unmatchable,
    }


}
