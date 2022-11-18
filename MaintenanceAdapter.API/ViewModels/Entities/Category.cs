namespace MaintenanceAdapter.API.ViewModels.Entities
{
    public class Category
    {
        public Category(string code, int establishmentWorkflow, bool isCarService, string label, string topLevelCode, int typeOfService)
        {
            Code = code;
            EstablishmentWorkflow = establishmentWorkflow;
            IsCarService = isCarService;
            Label = label;
            TopLevelCode = topLevelCode;
            TypeOfService = typeOfService;
        }

        public string Code { get; set; }
        public int EstablishmentWorkflow { get; set; }

        public bool IsCarService { get; set; }

        public string Label { get; set; }

        public string TopLevelCode { get; set; }

        public int TypeOfService { get; set; }
    }
}
