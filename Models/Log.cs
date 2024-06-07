namespace bamalhau.Models;
public record Log(
        string CorrelationId,
        string Application,
        string UpdateDate,
        object log
    );


