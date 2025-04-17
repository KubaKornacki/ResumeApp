namespace ResumeApp.Domain.Common;

public abstract class PeriodEntity:ResumeElementEntity
{
    public DateTime StartDatetime { get; set; }
    public DateTime EndDatetime { get; set; }
}
