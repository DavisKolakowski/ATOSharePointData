namespace ServicePortfolio.Shared.Objects.ATOServicePortfolio
{
    using Newtonsoft.Json;

    using System;

    public class ValueObj
    {
        public int Id { get; set; }

        [JsonProperty("@odata.etag")]
        public string OdataEtag { get; set; } = String.Empty;

        public ContentTypeObj ContentType { get; set; } = new ContentTypeObj();

        public CreatedByObj CreatedBy { get; set; } = new CreatedByObj();

        public DateTime CreatedDateTime { get; set; }

        public string ETag { get; set; } = String.Empty;

        public FieldsObj Fields { get; set; } = new FieldsObj();

        [JsonProperty("fields@odata.context")]
        public string FieldsOdataContext { get; set; } = String.Empty;

        public LastModifiedByObj LastModifiedBy { get; set; } = new LastModifiedByObj();

        public DateTime LastModifiedDateTime { get; set; }

        public ParentReferenceObj ParentReference { get; set; } = new ParentReferenceObj();

        public string WebUrl { get; set; } = String.Empty;
    }

}