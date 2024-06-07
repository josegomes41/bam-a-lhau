namespace bamalhau.Models;
public record Log(
        string CorrelationId,
        string Application,
        string UpdateDate,
        string log,
        string resume
    );


