using Microsoft.EntityFrameworkCore.Migrations;

namespace ORMFundamentals.Infrastructure.Store.Migrations
{
    public partial class addStoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE GetOrders 
	@productID INT NULL,
	@month INT NULL,
	@year INT NULL,
	@status INT NULL
AS
BEGIN
	SELECT ord.Id,ord.Status,ord.CreatedDate,ord.UpdatedDate,ord.ProductId FROM Orders ord INNER JOIN Products prod ON ord.ProductId=prod.Id 
	WHERE ProductId=ISNULL(productID,ProductId) AND MONTH(CreatedDate)=ISNULL(@month,MONTH(CreatedDate))
	AND YEAR(CreatedDate)=ISNULL(@year, YEAR(CreatedDate))
	AND Status=ISNULL(@status,Status)
END
GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE GetOrders");
        }
    }
}
