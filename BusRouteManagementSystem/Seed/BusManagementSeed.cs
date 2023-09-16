using BusRouteManagementSystem.Model;

namespace BusRouteManagementSystem.Seed
{
    public static class BusManagementSeed
    {
        public static List<Bus> Bus = new List<Bus>()
        {
            new Bus("9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca","MY1","Mahanagar yatayat"),
            new Bus("b5f8236a-927e-471e-8c75-66cf17f06df7","MY2","saja yatayat"),
            new Bus("0a97006a-8769-456a-8c85-674a547c1e2a","MY3","Mahasagar yatayat"),
            new Bus("6fa37e09-6e66-4f05-9d3e-2d8d57b24e18","MY4","Gagalfedi yatayat"),
            new Bus("59f6e2c2-7355-4c9b-80bb-41db468cf1ab","MY6","Micro BUS"),
            new Bus("4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f","MY7","Gokerneshwor"),




        };

        public static List<BusStop> BusStop = new List<BusStop>()
        {
            new BusStop("42d08f38-8756-4c09-b5df-6a65b5f8d0fe","Ratnapark"),
            new BusStop("6a65a3eb-901e-418f-bb3f-9ac0c68a9c64","Koteshwor "),
            new BusStop("cc376167-8b1a-4df7-bfd3-48e3542f73c5","Sankhu "),
            new BusStop("7fe7e1cb-63a2-4c6e-940f-63e7c85728c7","Gangabu "),
            new BusStop("b8fbbac3-e95a-47c7-950f-75e73a2ea4c9","Kalanki "),
            new BusStop("d2722cf0-2bfa-4e0e-b5c0-2c482c74b6a2","Sundarijal "),
            new BusStop("1e24207f-623a-4ab9-aa5a-16d21d986b82","Bhaktapur"),
            new BusStop("c4e4a12d-2b5a-4a97-8493-327ad0869f6a","Chabhil"),
            new BusStop("5b5f8d4a-0c62-4c06-94e1-aa6f02a7a1df","Thali"),
            new BusStop("9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5","Mulpani"),
             new BusStop("e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85","Jorpati"),
              new BusStop("d6c9e7b3-268f-44a2-bf24-4e82eb6efb36","Bouddha"),
              new BusStop("7a3f1d02-5c79-4803-9a2f-1c8559d3077d","Gausala"),
               new BusStop("2c171bb1-63a7-42d9-91e2-83de835c85a1","Medical college"),
               new BusStop("e4b9c7d3-1f8a-4672-92e5-6c3dab7f5e9d","Makalbari"),
        };

        public static List<BusBusStop> BusBusStop  = new List<BusBusStop>()
        {
            // gokarneshpwor
            new BusBusStop("04f7fc1a-1dcd-4a98-94f3-22a54a9b6c72",1,"4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f","e4b9c7d3-1f8a-4672-92e5-6c3dab7f5e9d"),
            new BusBusStop("b8ed93df-8b5d-4d13-a99f-794f7be43c46",2,"4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f","e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"),
            new BusBusStop("3e9d01b6-894d-4f26-b17b-8c5d5d5d18e1",3,"4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f","d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"),
            new BusBusStop("7f52c417-63e1-4a7a-9fe6-9b2ca63c3e0e",4,"4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f","c4e4a12d-2b5a-4a97-8493-327ad0869f6a"),
            new BusBusStop("2c7c191e-6bc7-46d5-a71d-9b73fbbef4b0",5,"4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f","7a3f1d02-5c79-4803-9a2f-1c8559d3077d"),
            new BusBusStop("1785c8eb-6c10-4c0f-88a3-2a5f3ef1ce2a",6,"4e1c45c7-9b43-4ef5-a63d-bc6e0f932c5f","6a65a3eb-901e-418f-bb3f-9ac0c68a9c64"),

              //micro bus 2
            new BusBusStop("986dbec4-3e16-4a8d-9b3b-06d9ac10543b",1,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","2c171bb1-63a7-42d9-91e2-83de835c85a1"),
            new BusBusStop("6d9f5e0d-4cf2-4a6d-8f1f-835fbf30753d",2,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"),
            new BusBusStop("bcf3e70c-3f4b-48e6-b1b9-c6e01b07f0f4",3,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"),
            new BusBusStop("1a72f6a8-c7b9-45e1-8f59-3b45d81c71ac",4,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","c4e4a12d-2b5a-4a97-8493-327ad0869f6a"),
            new BusBusStop("3b6c7d2b-89f6-4f70-ae6b-147dab2e9243",5,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","7a3f1d02-5c79-4803-9a2f-1c8559d3077d"),
            new BusBusStop("a5f8e7d1-4b9c-4e2d-93c7-8fd291c874a0",6,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","42d08f38-8756-4c09-b5df-6a65b5f8d0fe"),

              //micro bus
            new BusBusStop("b3e92c52-581c-4f69-9c02-d6b96e12f64d",1,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"),
            new BusBusStop("2e871889-45a4-4ab5-aa65-7f6cc9e95115",2,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"),
            new BusBusStop("ebae82c2-8db4-4630-b1d4-7c3e56c3d44d",3,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"),
            new BusBusStop("18cb1a0e-2c4b-4ea7-b93f-43914d106d5e",4,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","c4e4a12d-2b5a-4a97-8493-327ad0869f6a"),
            new BusBusStop("e0ce685a-5867-401e-bb7e-91b59b1bea3a",5,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","7a3f1d02-5c79-4803-9a2f-1c8559d3077d"),
            new BusBusStop("894af329-0137-4f1b-99f1-6f1a58f4e22a",6,"59f6e2c2-7355-4c9b-80bb-41db468cf1ab","42d08f38-8756-4c09-b5df-6a65b5f8d0fe"),

            //mahasagar 2
            new BusBusStop("d5788ea1-7403-48c9-874d-0d5c3edf1ea2",1,"0a97006a-8769-456a-8c85-674a547c1e2a","9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"),
            new BusBusStop("82378d4c-7a7d-4b18-89d5-c1a0fe738b2e",2,"0a97006a-8769-456a-8c85-674a547c1e2a","e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"),
            new BusBusStop("f3d98ed6-38fe-49e5-9075-0b2c300d5e5a",3,"0a97006a-8769-456a-8c85-674a547c1e2a","d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"),
            new BusBusStop("48656d8f-4ee6-45b3-9602-180e913f0a47",4,"0a97006a-8769-456a-8c85-674a547c1e2a","c4e4a12d-2b5a-4a97-8493-327ad0869f6a"),
            new BusBusStop("160c50e6-1b24-45a6-9db1-0d0b387c9c07",5,"0a97006a-8769-456a-8c85-674a547c1e2a","7fe7e1cb-63a2-4c6e-940f-63e7c85728c7"),
            new BusBusStop("75a17dd9-1a63-4e5d-97b5-26b219d69597",6,"0a97006a-8769-456a-8c85-674a547c1e2a","b8fbbac3-e95a-47c7-950f-75e73a2ea4c9"),

             //gagalfedi
            new BusBusStop("5dc48e06-50f7-47b5-9e0d-72d856ec3a63",1,"6fa37e09-6e66-4f05-9d3e-2d8d57b24e18","5b5f8d4a-0c62-4c06-94e1-aa6f02a7a1df"),
            new BusBusStop("4fb2deac-87b7-4717-b82c-7db77197f846",2,"6fa37e09-6e66-4f05-9d3e-2d8d57b24e18","9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"),
            new BusBusStop("7d1f8e45-7c3e-4c63-8cfc-d8a73c1a70a5",3,"6fa37e09-6e66-4f05-9d3e-2d8d57b24e18","e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"),
            new BusBusStop("a2e8f174-7fb3-40a5-bf65-47c0a8b36525",4,"6fa37e09-6e66-4f05-9d3e-2d8d57b24e18","d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"),

            new BusBusStop("6eaa7ef5-81a7-4151-a1f7-4f2a82b7679b",5,"6fa37e09-6e66-4f05-9d3e-2d8d57b24e18","c4e4a12d-2b5a-4a97-8493-327ad0869f6a"),

            new BusBusStop("c75a12e7-6e4c-4be0-8e48-33de929cd6b7",6,"6fa37e09-6e66-4f05-9d3e-2d8d57b24e18","7a3f1d02-5c79-4803-9a2f-1c8559d3077d"),
            new BusBusStop("94f9630b-e4c9-42d5-b71b-7d44219ab77c",7,"6fa37e09-6e66-4f05-9d3e-2d8d57b24e18","42d08f38-8756-4c09-b5df-6a65b5f8d0fe"),

            new BusBusStop("f3a4e1c9-0c09-4fe4-812d-1b2ff591a195",8,"6fa37e09-6e66-4f05-9d3e-2d8d57b24e18","b8fbbac3-e95a-47c7-950f-75e73a2ea4c9"),
             //Mahasagar yatat
            new BusBusStop("e5ea6b7d-4d03-46f1-a3f7-54a58a5047e1",1,"0a97006a-8769-456a-8c85-674a547c1e2a","d2722cf0-2bfa-4e0e-b5c0-2c482c74b6a2"),
            new BusBusStop("501d3e3b-4c2d-432f-b81d-94b5d9814322",2,"0a97006a-8769-456a-8c85-674a547c1e2a","2c171bb1-63a7-42d9-91e2-83de835c85a1"),
            new BusBusStop("f43b6e6a-665b-47e3-b698-5d396c62cabe",3,"0a97006a-8769-456a-8c85-674a547c1e2a","e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"),
            new BusBusStop("82daafaf-6090-4e66-979b-1a939df19f29",4,"0a97006a-8769-456a-8c85-674a547c1e2a","c4e4a12d-2b5a-4a97-8493-327ad0869f6a"),
            new BusBusStop("e302d6ac-7a6f-4e9d-aae7-46d8b2a9948e",5,"0a97006a-8769-456a-8c85-674a547c1e2a","7a3f1d02-5c79-4803-9a2f-1c8559d3077d"),
            new BusBusStop("6dbf0e5e-85a9-4e02-bc77-b67d7711c18d",6,"0a97006a-8769-456a-8c85-674a547c1e2a","42d08f38-8756-4c09-b5df-6a65b5f8d0fe"),

            //Mahanagar YATAYAT
            new BusBusStop("ec788798-6b1a-45e3-9ef1-3d589f8626d3",1,"9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca","cc376167-8b1a-4df7-bfd3-48e3542f73c5"),
            new BusBusStop("f95f792b-0b47-4eeb-8e9a-652edbd46c9d",2,"9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca","5b5f8d4a-0c62-4c06-94e1-aa6f02a7a1df"),
            new BusBusStop("9af1d2f0-52bb-4d3f-8a47-cbdfcb85b4d9",3,"9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca","9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"),
            new BusBusStop("8eef0d79-717d-4da1-bbb7-881c830b57e3",4,"9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca","e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"),
            new BusBusStop("32a0e99a-8e4a-45c6-9f87-95cc71a35877",5,"9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca","d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"),
            new BusBusStop("6d418f6c-2fe6-4c92-9c53-15e33a157a3b",6,"9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca","c4e4a12d-2b5a-4a97-8493-327ad0869f6a"),
            new BusBusStop("b654fad3-e38e-49d7-9ef5-d10a80a9a12e",7,"9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca","7a3f1d02-5c79-4803-9a2f-1c8559d3077d"),
            new BusBusStop("36e5411d-42a3-4d3f-9c0c-4bb4b6a2820c",8,"9c1d3c8c-99b6-4df7-bca1-74e78ce8e5ca","6a65a3eb-901e-418f-bb3f-9ac0c68a9c64"),

                 //saja yatayat
            new BusBusStop("d1286c35-42df-4777-9c9b-7402b9b3285c",1,"b5f8236a-927e-471e-8c75-66cf17f06df7","cc376167-8b1a-4df7-bfd3-48e3542f73c5"),
            new BusBusStop("c57193d8-4b0d-421f-82f1-06ff1ac50d75",2,"b5f8236a-927e-471e-8c75-66cf17f06df7","5b5f8d4a-0c62-4c06-94e1-aa6f02a7a1df"),
            new BusBusStop("7e9b530e-ae19-4b91-b53b-44f96b0e6011",3,"b5f8236a-927e-471e-8c75-66cf17f06df7","9f7b8e26-3ac9-467d-9b3e-688a63b8d1e5"),
            new BusBusStop("b63685df-2e68-4c25-8919-25b20f372e2a",4,"b5f8236a-927e-471e-8c75-66cf17f06df7","e8a4cf7f-31fc-4b09-a57e-8a1c6e741b85"),
            new BusBusStop("91e3ca2e-99a3-4b36-8801-7844d7cb82d9",5,"b5f8236a-927e-471e-8c75-66cf17f06df7","d6c9e7b3-268f-44a2-bf24-4e82eb6efb36"),
            new BusBusStop("3f7a2db2-e1d7-4923-bb42-1e5a1db41633",6,"b5f8236a-927e-471e-8c75-66cf17f06df7","c4e4a12d-2b5a-4a97-8493-327ad0869f6a"),
            new BusBusStop("8e5b193c-96c5-43a3-9e2e-19ce508cee53",7,"b5f8236a-927e-471e-8c75-66cf17f06df7","7a3f1d02-5c79-4803-9a2f-1c8559d3077d"),
            new BusBusStop("64a3c1f0-8931-4d9d-b739-aa5920f38388",8,"b5f8236a-927e-471e-8c75-66cf17f06df7","6a65a3eb-901e-418f-bb3f-9ac0c68a9c64"),
            new BusBusStop("f3e05278-9f5e-41d3-b37b-5d40c636d9f0",9,"b5f8236a-927e-471e-8c75-66cf17f06df7","1e24207f-623a-4ab9-aa5a-16d21d986b82"),

          
      
        };

    }

}
