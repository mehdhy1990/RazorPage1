namespace RazorPageProect.CoreLayer;

public class OperationResult
{
    public string Message { get; set; }
    public OperationResultStatus Status { get; set; }

    #region Errors
    public static OperationResult Error()
    {
        return new OperationResult()
        {
            Status = OperationResultStatus.Error,
            Message = "Failed",
        };
    }
    public static OperationResult Error(string message)
    {
        return new OperationResult()
        {
            Status = OperationResultStatus.Error,
            Message = message,
        };
    }
    #endregion

    #region NotFound

    public static OperationResult NotFound(string message)
    {
        return new OperationResult()
        {
            Status = OperationResultStatus.NotFound,
            Message = message,
        };
    }
    public static OperationResult NotFound()
    {
        return new OperationResult()
        {
            Status = OperationResultStatus.NotFound,
            Message = "Not found",
        };
    }

    #endregion

    #region Succsess

    public static OperationResult Success()
    {
        return new OperationResult()
        {
            Status = OperationResultStatus.Success,
            Message = "Success",
        };
    }
    public static OperationResult Success(string message)
    {
        return new OperationResult()
        {
            Status = OperationResultStatus.Success,
            Message = message,
        };
    }
    #endregion
}
public enum OperationResultStatus
{
    Error = 10,
    Success = 200,
    NotFound = 404
}
