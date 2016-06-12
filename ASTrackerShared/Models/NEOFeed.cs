using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ASTrackerShared.Models
{
    public class NEOFeed
    {

    }
    [DataContract]
    public class Links
    {
        [DataMember]
        public string next { get; set; }
        [DataMember]
        public string prev { get; set; }
        [DataMember]
        public string self { get; set; }
    }

    [DataContract]
    public class Links2
    {
        [DataMember]
        public string self { get; set; }
    }

    [DataContract]
    public class Kilometers
    {
        [DataMember]
        public double estimated_diameter_min { get; set; }
        [DataMember]
        public double estimated_diameter_max { get; set; }
    }

    [DataContract]
    public class Meters
    {
        [DataMember]
        public double estimated_diameter_min { get; set; }
        [DataMember]
        public double estimated_diameter_max { get; set; }
    }

    [DataContract]
    public class Miles
    {
        [DataMember]
        public double estimated_diameter_min { get; set; }
        [DataMember]
        public double estimated_diameter_max { get; set; }
    }

    [DataContract]
    public class Feet
    {
        [DataMember]
        public double estimated_diameter_min { get; set; }
        [DataMember]
        public double estimated_diameter_max { get; set; }
    }

    [DataContract]
    public class EstimatedDiameter
    {
        [DataMember]
        public Kilometers kilometers { get; set; }
        [DataMember]
        public Meters meters { get; set; }
        [DataMember]
        public Miles miles { get; set; }
        [DataMember]
        public Feet feet { get; set; }
    }

    [DataContract]
    public class RelativeVelocity
    {
        [DataMember]
        public string kilometers_per_second { get; set; }
        [DataMember]
        public string kilometers_per_hour { get; set; }
        [DataMember]
        public string miles_per_hour { get; set; }
    }

    [DataContract]
    public class MissDistance
    {
        [DataMember]
        public string astronomical { get; set; }
        [DataMember]
        public string lunar { get; set; }
        [DataMember]
        public string kilometers { get; set; }
        [DataMember]
        public string miles { get; set; }
    }

    [DataContract]
    public class CloseApproachData
    {
        [DataMember]
        public string close_approach_date { get; set; }
        [DataMember]
        public object epoch_date_close_approach { get; set; }
        [DataMember]
        public RelativeVelocity relative_velocity { get; set; }
        [DataMember]
        public MissDistance miss_distance { get; set; }
        [DataMember]
        public string orbiting_body { get; set; }
    }

    [DataContract]
    public class __invalid_type__20150908
    {
        [DataMember]
        public Links2 links { get; set; }
        [DataMember]
        public string neo_reference_id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string nasa_jpl_url { get; set; }
        [DataMember]
        public double absolute_magnitude_h { get; set; }
        [DataMember]
        public EstimatedDiameter estimated_diameter { get; set; }
        [DataMember]
        public bool is_potentially_hazardous_asteroid { get; set; }
        [DataMember]
        public List<CloseApproachData> close_approach_data { get; set; }
        [DataMember]
        public object orbital_data { get; set; }
    }

    [DataContract]
    public class Links3
    {
        [DataMember]
        public string self { get; set; }
    }

    [DataContract]
    public class Kilometers2
    {
        [DataMember]
        public double estimated_diameter_min { get; set; }
        [DataMember]
        public double estimated_diameter_max { get; set; }
    }

    [DataContract]
    public class Meters2
    {
        [DataMember]
        public double estimated_diameter_min { get; set; }
        [DataMember]
        public double estimated_diameter_max { get; set; }
    }

    [DataContract]
    public class Miles2
    {
        [DataMember]
        public double estimated_diameter_min { get; set; }
        [DataMember]
        public double estimated_diameter_max { get; set; }
    }

    [DataContract]
    public class Feet2
    {
        [DataMember]
        public double estimated_diameter_min { get; set; }
        [DataMember]
        public double estimated_diameter_max { get; set; }
    }

    [DataContract]
    public class EstimatedDiameter2
    {
        [DataMember]
        public Kilometers2 kilometers { get; set; }
        [DataMember]
        public Meters2 meters { get; set; }
        [DataMember]
        public Miles2 miles { get; set; }
        [DataMember]
        public Feet2 feet { get; set; }
    }

    [DataContract]
    public class RelativeVelocity2
    {
        [DataMember]
        public string kilometers_per_second { get; set; }
        [DataMember]
        public string kilometers_per_hour { get; set; }
        [DataMember]
        public string miles_per_hour { get; set; }
    }

    [DataContract]
    public class MissDistance2
    {
        [DataMember]
        public string astronomical { get; set; }
        [DataMember]
        public string lunar { get; set; }
        [DataMember]
        public string kilometers { get; set; }
        [DataMember]
        public string miles { get; set; }
    }

    [DataContract]
    public class CloseApproachData2
    {
        [DataMember]
        public string close_approach_date { get; set; }
        [DataMember]
        public object epoch_date_close_approach { get; set; }
        [DataMember]
        public RelativeVelocity2 relative_velocity { get; set; }
        [DataMember]
        public MissDistance2 miss_distance { get; set; }
        [DataMember]
        public string orbiting_body { get; set; }
    }

    [DataContract]
    public class __invalid_type__20150907
    {
        [DataMember]
        public Links3 links { get; set; }
        [DataMember]
        public string neo_reference_id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string nasa_jpl_url { get; set; }
        [DataMember]
        public double absolute_magnitude_h { get; set; }
        [DataMember]
        public EstimatedDiameter2 estimated_diameter { get; set; }
        [DataMember]
        public bool is_potentially_hazardous_asteroid { get; set; }
        [DataMember]
        public List<CloseApproachData2> close_approach_data { get; set; }
        [DataMember]
        public object orbital_data { get; set; }
    }

    [DataContract]
    public class NearEarthObjects
    {
        [DataMember]
        public List<__invalid_type__20150908> __invalid_name__20150908 { get; set; }
        [DataMember]
        public List<__invalid_type__20150907> __invalid_name__20150907 { get; set; }
    }

    [DataContract]
    public class RootObject
    {
        [DataMember]
        public Links links { get; set; }
        [DataMember]
        public int element_count { get; set; }
        [DataMember]
        public NearEarthObjects near_earth_objects { get; set; }
    }
}
