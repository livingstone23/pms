using System.ComponentModel.DataAnnotations;



namespace PVM.TMU.Extensions.Helpers;



public class ValidationHelpers
{
    
    public List<ValidationResult> validationResults = new List<ValidationResult>();
    private ValidationContext validationContext;
    private object instance;
    
    public ValidationHelpers(object instance)
    {
        this.instance = instance;
        validationContext = new ValidationContext(instance);
    }

    public bool Validate()
    {
        return Validator.TryValidateObject(instance, validationContext, validationResults, true);
    }

}