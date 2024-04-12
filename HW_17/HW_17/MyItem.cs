using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/*4. Создайте класс MyItem c 2мя public свойствами: Age и Name. 
 * Создайте объект данного типа. 
 * Сериализуйте этот обект в JSON используя Newtonsoft.Json так, 
 * чтобы поле Name не попадало в JSON, а значение Age было в поле JSON с именем MyAge.*/

namespace HW_17
{
    public class MyItem
    {
        [JsonIgnore]
        public string? Name { get; set; }
        [JsonProperty("MyAge")]
        public string? Age { get; set; }
    }
}
