using bamalhau.Models;

namespace bamalhau.Services;

public interface ICosmosService
{
    public async Task<IEnumerable<Product>> RetrieveActiveProductsAsync()
    {
        await Task.Delay(1);

        return new List<Product>()
        {
            new Product(id: "baaa4d2d-5ebe-45fb-9a5c-d06876f408e0", category: new Category(name: "Components, Road Frames"), sku: "FR-R72R-60", name: """ML Road Frame - Red, 60""", description: """The product called "ML Road Frame - Red, 60".""", price: 594.83000000000004m),
            new Product(id: "bd43543e-024c-4cda-a852-e29202310214", category: new Category(name: "Components, Forks"), sku: "FK-5136", name: """ML Fork""", description: """The product called "ML Fork".""", price: 175.49000000000001m),
            new Product(id: "2aeceeb7-adb8-4c43-9050-2054420b5a06", category: new Category(name: "Components, Road Frames"), sku: "FR-R38R-52", name: """LL Road Frame - Red, 52""", description: """The product called "LL Road Frame - Red, 52".""", price: 337.22000000000003m),
            new Product(id: "e1a27eca-0ec8-48b7-8998-b0971d027280", category: new Category(name: "Components, Road Frames"), sku: "FR-R38B-62", name: """LL Road Frame - Black, 62""", description: """The product called "LL Road Frame - Black, 62".""", price: 337.22000000000003m),
            new Product(id: "60dea2b5-63cd-4338-896e-a1eb292e8d3f", category: new Category(name: "Components, Road Frames"), sku: "FR-R72Y-38", name: """ML Road Frame-W - Yellow, 38""", description: """The product called "ML Road Frame-W - Yellow, 38".""", price: 594.83000000000004m),
            new Product(id: "ee646dc9-2b52-44de-af51-fce7115848c8", category: new Category(name: "Components, Road Frames"), sku: "FR-R72Y-42", name: """ML Road Frame-W - Yellow, 42""", description: """The product called "ML Road Frame-W - Yellow, 42".""", price: 594.83000000000004m),
            new Product(id: "9c76c9f8-4939-4efd-80e0-a69da6901b60", category: new Category(name: "Components, Road Frames"), sku: "FR-R92B-52", name: """HL Road Frame - Black, 52""", description: """The product called "HL Road Frame - Black, 52".""", price: 1431.5m),
            new Product(id: "444b580c-81fb-4b2d-9537-1368ccfba6ec", category: new Category(name: "Components, Road Frames"), sku: "FR-R92B-44", name: """HL Road Frame - Black, 44""", description: """The product called "HL Road Frame - Black, 44".""", price: 1431.5m),
            new Product(id: "7c434cca-51af-4f30-b37e-9cb6920ef548", category: new Category(name: "Components, Road Frames"), sku: "FR-R38R-44", name: """LL Road Frame - Red, 44""", description: """The product called "LL Road Frame - Red, 44".""", price: 337.22000000000003m),
            new Product(id: "d5928182-0307-4bf9-8624-316b9720c58c", category: new Category(name: "Components, Cranksets"), sku: "CS-6583", name: """ML Crankset""", description: """The product called "ML Crankset".""", price: 256.49000000000001m)
        };
    }

    public async Task<IEnumerable<Product>> RetrieveAllProductsAsync()
    {
        await Task.Delay(1);

        return new List<Product>()
        {
            new Product(id: "a7242fe2-1966-49b7-9ed6-ae6f30d0e0e3", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M94S-52", name: """HL Mountain Frame - Silver, 48""", description: """The product called "HL Mountain Frame - Silver, 48".""", price: 1364.5m),
            new Product(id: "b1a8a599-f876-468f-be58-d96ed1f21ca8", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R50R-48", name: """Road-650 Red, 48""", description: """The product called "Road-650 Red, 48".""", price: 782.99000000000001m),
            new Product(id: "3c2adee9-d928-4f44-8e15-3ab97d705feb", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R19B-48", name: """Road-750 Black, 48""", description: """The product called "Road-750 Black, 48".""", price: 539.99000000000001m),
            new Product(id: "24338025-e187-4554-91ee-c5723340195c", category: new Category(name: "Components, Wheels"), sku: "FW-R623", name: """LL Road Front Wheel""", description: """The product called "LL Road Front Wheel".""", price: 85.564999999999998m),
            new Product(id: "1dcc7365-8d37-444d-9163-cd8f0c999fba", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R64Y-48", name: """Road-550-W Yellow, 48""", description: """The product called "Road-550-W Yellow, 48".""", price: 1120.49m),
            new Product(id: "86e210fd-f25a-447f-b081-ab33c0b5322e", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M94B-46", name: """HL Mountain Frame - Black, 46""", description: """The product called "HL Mountain Frame - Black, 46".""", price: 1349.5999999999999m),
            new Product(id: "2bb193ff-a1e7-41ef-98ec-9ee0478e8b39", category: new Category(name: "Clothing, Socks"), sku: "SO-R809-L", name: """Racing Socks, L""", description: """The product called "Racing Socks, L".""", price: 8.9900000000000002m),
            new Product(id: "8ad6c2b4-1adb-4f00-8c4d-473b62946aa9", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M21B-52", name: """LL Mountain Frame - Black, 52""", description: """The product called "LL Mountain Frame - Black, 52".""", price: 249.78999999999999m),
            new Product(id: "6adba2b1-b0fe-48ea-a3a2-7f30cd2d737b", category: new Category(name: "Clothing, Shorts"), sku: "SH-M897-X", name: """Men's Sports Shorts, XL""", description: """The product called "Men's Sports Shorts, XL".""", price: 59.990000000000002m),
            new Product(id: "4bdbe6a2-ace7-42ce-af76-2f7027f8773f", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R68R-44", name: """Road-450 Red, 44""", description: """The product called "Road-450 Red, 44".""", price: 1457.99m),
            new Product(id: "840cdfe7-239a-4117-b9d2-668abff13e6f", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R50B-52", name: """Road-650 Black, 52""", description: """The product called "Road-650 Black, 52".""", price: 782.99000000000001m),
            new Product(id: "32ad9a2e-55bc-44e8-8d37-e2a801c3a480", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R64Y-40", name: """Road-550-W Yellow, 40""", description: """The product called "Road-550-W Yellow, 40".""", price: 1120.49m),
            new Product(id: "46580448-2ba3-4ac0-a08c-9f8a1d47154c", category: new Category(name: "Clothing, Shorts"), sku: "SH-M897-M", name: """Men's Sports Shorts, M""", description: """The product called "Men's Sports Shorts, M".""", price: 59.990000000000002m),
            new Product(id: "e46725c7-a455-495a-b4ce-03370906e4d0", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M21B-48", name: """LL Mountain Frame - Black, 48""", description: """The product called "LL Mountain Frame - Black, 48".""", price: 249.78999999999999m),
            new Product(id: "1370baa6-ae19-4614-8439-b1ce34e45aaf", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M94S-44", name: """HL Mountain Frame - Silver, 44""", description: """The product called "HL Mountain Frame - Silver, 44".""", price: 1364.5m),
            new Product(id: "8bfe08bc-d5d3-427b-81e2-6a0c5e6ef36d", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M21B-40", name: """LL Mountain Frame - Black, 40""", description: """The product called "LL Mountain Frame - Black, 40".""", price: 249.78999999999999m),
            new Product(id: "13c78327-106e-4adc-8f72-bde758e6873a", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R64Y-42", name: """Road-550-W Yellow, 42""", description: """The product called "Road-550-W Yellow, 42".""", price: 1120.49m),
            new Product(id: "44cf3949-8b6d-46dc-91bd-b4704d00bba6", category: new Category(name: "Accessories, Bike Racks"), sku: "RA-H123", name: """Hitch Rack - 4-Bike""", description: """The product called "Hitch Rack - 4-Bike".""", price: 120.0m),
            new Product(id: "0aa64953-c746-43f4-8e12-82cd9d3386ee", category: new Category(name: "Components, Wheels"), sku: "RW-R820", name: """HL Road Rear Wheel""", description: """The product called "HL Road Rear Wheel".""", price: 357.06m),
            new Product(id: "52d9c336-fa77-443f-8608-8cccac1e2a81", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M63S-40", name: """ML Mountain Frame-W - Silver, 40""", description: """The product called "ML Mountain Frame-W - Silver, 40".""", price: 364.08999999999997m),
            new Product(id: "6cf83614-4381-4211-b443-883d76c111a2", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R79Y-44", name: """Road-350-W Yellow, 44""", description: """The product called "Road-350-W Yellow, 44".""", price: 1700.99m),
            new Product(id: "85b8a1e4-2a73-4b62-80b1-607fc4d2b61a", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M63B-48", name: """ML Mountain Frame - Black, 48""", description: """The product called "ML Mountain Frame - Black, 48".""", price: 348.75999999999999m),
            new Product(id: "f1e427df-653f-4bcd-b973-23f1eece5e54", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R93R-52", name: """Road-150 Red, 52""", description: """The product called "Road-150 Red, 52".""", price: 3578.27m),
            new Product(id: "88af1975-9a4c-4c98-9538-4a858ef43232", category: new Category(name: "Components, Handlebars"), sku: "HB-M918", name: """HL Mountain Handlebars""", description: """The product called "HL Mountain Handlebars".""", price: 120.27m),
            new Product(id: "f7684f0c-3811-429f-956c-ccbd76d2b914", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R50R-60", name: """Road-650 Red, 60""", description: """The product called "Road-650 Red, 60".""", price: 782.99000000000001m),
            new Product(id: "0f548b2d-db83-42ac-84cd-fe1a10440f62", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R93R-56", name: """Road-150 Red, 56""", description: """The product called "Road-150 Red, 56".""", price: 3578.27m),
            new Product(id: "ecefdde3-ac3d-4482-906d-7ef882fc77f3", category: new Category(name: "Components, Wheels"), sku: "RW-M423", name: """LL Mountain Rear Wheel""", description: """The product called "LL Mountain Rear Wheel".""", price: 87.745000000000005m),
            new Product(id: "91df0c55-915c-4c7d-8cf3-04712a59e435", category: new Category(name: "Clothing, Socks"), sku: "SO-B909-L", name: """Mountain Bike Socks, L""", description: """The product called "Mountain Bike Socks, L".""", price: 9.5m),
            new Product(id: "65ac8fa1-de76-4c3f-87dd-cdf522a93aba", category: new Category(name: "Components, Wheels"), sku: "FW-M928", name: """HL Mountain Front Wheel""", description: """The product called "HL Mountain Front Wheel".""", price: 300.21499999999997m),
            new Product(id: "a779aa08-c60f-4474-86a4-7600b2483a87", category: new Category(name: "Components, Wheels"), sku: "RW-M928", name: """HL Mountain Rear Wheel""", description: """The product called "HL Mountain Rear Wheel".""", price: 327.21499999999997m),
            new Product(id: "1e94304a-eacd-48b2-b7dc-dc0a822dc494", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R93R-62", name: """Road-150 Red, 62""", description: """The product called "Road-150 Red, 62".""", price: 3578.27m),
            new Product(id: "c2782a2c-33ac-4d2f-bebf-5fda4212987a", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M63S-46", name: """ML Mountain Frame-W - Silver, 46""", description: """The product called "ML Mountain Frame-W - Silver, 46".""", price: 364.08999999999997m),
            new Product(id: "f7168c29-1f92-41de-b42e-f35ea25b0bc5", category: new Category(name: "Components, Wheels"), sku: "RW-R762", name: """ML Road Rear Wheel""", description: """The product called "ML Road Rear Wheel".""", price: 275.38499999999999m),
            new Product(id: "617ccfb7-4481-49b9-a0b6-52e5f047ee66", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R93R-48", name: """Road-150 Red, 48""", description: """The product called "Road-150 Red, 48".""", price: 3578.27m),
            new Product(id: "894fbd05-d5cd-4488-b8ad-8d6747b737fc", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R50B-48", name: """Road-650 Black, 48""", description: """The product called "Road-650 Black, 48".""", price: 782.99000000000001m),
            new Product(id: "ecdfb382-3e94-4de1-9834-52db88208069", category: new Category(name: "Components, Handlebars"), sku: "HB-M243", name: """LL Mountain Handlebars""", description: """The product called "LL Mountain Handlebars".""", price: 44.539999999999999m),
            new Product(id: "2d623868-7431-4ac9-ba44-0e5d44a98a5a", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M21B-42", name: """LL Mountain Frame - Black, 42""", description: """The product called "LL Mountain Frame - Black, 42".""", price: 249.78999999999999m),
            new Product(id: "e992f670-c624-41f1-9dc6-33615a923e35", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R50B-62", name: """Road-650 Black, 62""", description: """The product called "Road-650 Black, 62".""", price: 782.99000000000001m),
            new Product(id: "2178f01b-9647-4758-9938-8b28f46a777c", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R64Y-38", name: """Road-550-W Yellow, 38""", description: """The product called "Road-550-W Yellow, 38".""", price: 1120.49m),
            new Product(id: "a5c22ac7-8f65-49f7-a9df-61d4599b327e", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M63B-40", name: """ML Mountain Frame - Black, 40""", description: """The product called "ML Mountain Frame - Black, 40".""", price: 348.75999999999999m),
            new Product(id: "b76e2e02-c88b-4945-977f-8eeb6894cd44", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M94B-48", name: """HL Mountain Frame - Black, 48""", description: """The product called "HL Mountain Frame - Black, 48".""", price: 1349.5999999999999m),
            new Product(id: "d1eb7c29-f0ef-4cf9-b182-d95e7d4bfb3e", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R89R-58", name: """Road-250 Red, 58""", description: """The product called "Road-250 Red, 58".""", price: 2443.3499999999999m),
            new Product(id: "254eaecf-0409-4c30-9249-390350fc38b9", category: new Category(name: "Components, Wheels"), sku: "RW-R623", name: """LL Road Rear Wheel""", description: """The product called "LL Road Rear Wheel".""", price: 112.565m),
            new Product(id: "e5cae552-19fb-4686-98ed-b529c6827eaf", category: new Category(name: "Components, Wheels"), sku: "RW-M762", name: """ML Mountain Rear Wheel""", description: """The product called "ML Mountain Rear Wheel".""", price: 236.02500000000001m),
            new Product(id: "22474385-cfdf-4736-b741-078a77855c80", category: new Category(name: "Clothing, Caps"), sku: "CA-1098", name: """AWC Logo Cap""", description: """The product called "AWC Logo Cap".""", price: 8.9900000000000002m),
            new Product(id: "694adc52-7055-40ab-8b0a-909da2d03642", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M94S-38", name: """HL Mountain Frame - Silver, 38""", description: """The product called "HL Mountain Frame - Silver, 38".""", price: 1364.5m),
            new Product(id: "e094e332-13ce-438b-9118-04537e033d7e", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R50R-62", name: """Road-650 Red, 62""", description: """The product called "Road-650 Red, 62".""", price: 782.99000000000001m),
            new Product(id: "00e5f58e-e0e6-4856-bea4-e90929a2165e", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R64Y-44", name: """Road-550-W Yellow, 44""", description: """The product called "Road-550-W Yellow, 44".""", price: 1120.49m),
            new Product(id: "52ebe2d7-e402-45b6-bfe9-eac409e45c2e", category: new Category(name: "Bikes, Road Bikes"), sku: "BK-R50B-60", name: """Road-650 Black, 60""", description: """The product called "Road-650 Black, 60".""", price: 782.99000000000001m),
            new Product(id: "dab34a6d-44b5-4cd6-92b6-3c1eab1de1a4", category: new Category(name: "Components, Mountain Frames"), sku: "FR-M94B-42", name: """HL Mountain Frame - Black, 42""", description: """The product called "HL Mountain Frame - Black, 42".""", price: 1349.5999999999999m)
        };
    }
}