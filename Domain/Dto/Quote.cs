
namespace Domain.Dto;
public  class QuoteDto
{
    public object id;

    public int Id { get; set; }
    public string ? Author { get; set; }
    public string ? QuoteText { get; set; }
    public int Categoryid { get; set; }
}
