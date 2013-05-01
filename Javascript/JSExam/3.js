function Solve(args) {
    var bad = args[0].split("]");
    var temp = bad[0].split(" ");
    var k = 0;
    var arrayValues = [];
    var arrayNames = [];
    var index = 0;
    while (temp[0] === "def") {

        var bad = args[k].split("]");
        var something = bad[0].split("[");
        var words = something[0].split(" ");
        var name = words[1];
        arrayNames[index] = name;
        var values = something[1].split(", ");
        for (var i = 0; i < values.length; i++) {
            values[i] = values[i].trim();
            for (var j = 0; j < arrayNames.length; j++) {
                if (values[i] === arrayNames[j])
                {
                    values[i] = arrayValues[j];
                    
                }

            }
            values[i] = parseInt(values[i]);

        }
        if (words.length > 2) {
            switch (words[2]) {
                case "sum":
                    {
                        
                        var sum = 0;
                        for (var i = 0; i < values.length; i++) {
                            
                            sum = sum + values[i];
                            console.log("value");
                            console.log(values[i])
                            console.log("sum")
                            console.log(sum)
                        }
                        arrayValues[index] = sum;
                        break;
                    }
                case "min":
                    {

                        var min = values[0];
                        for (var i = 0; i < values.length; i++) {
                            if (values[i]<min) {
                                min = values[i];
                            }
                        }
                        arrayValues[index] = min;
                        break;
                    }
                case "max":
                    {

                        var min = values[0];
                        for (var i = 0; i < values.length; i++) {
                            if (values[i] > min) {
                                min = values[i];
                            }
                        }
                        arrayValues[index] = min;
                        break;
                    }
                case "avg":
                    {

                        var sum = 0;
                        for (var i = 0; i < values.length; i++) {
                            sum += values[i];
                        }
                        arrayValues[index] = sum/values.length;
                        break;
                    }
                default:
                    {
                        arrayValues[index] = values[0];
                        break;
                    }

            }

        }
        else {

        }

        k++;
        bad = args[k].split("]");
        temp = bad[0].split(" ");
        index++;
    }
    var bado = args[args.length - 1].split("]");
    var func = bad[0].split("[");
    var val = func[1].split(", ");

    for (var i = 0; i < val.length; i++) {
        val[i] = val[i].trim();
        for (var j = 0; j < arrayNames.length; j++) {
            if (val[i] === arrayNames[j]) {
                val[i] = arrayValues[j];

            }
            //val[i] = parseInt(val[i]);
        }
    }
        switch (func[0]) {
            case "sum":
                {
                        
                    var sum = 0;
                    for (var i = 0; i < val.length; i++) {
                        sum += val[i];
                    }
                    return sum;
                    break;
                }
            case "min":
                {

                    var min = val[0];
                    for (var i = 0; i < val.length; i++) {
                        if (val[i]<min) {
                            min = val[i];
                        }
                    }
                    return min;
                    break;
                }
            case "max":
                {

                    var min = val[0];
                    for (var i = 0; i < values.length; i++) {
                        if (val[i] > min) {
                            min = val[i];
                        }
                    }
                    return min;
                    break;
                }
            case "avg":
                {

                    var sum = 0;
                    for (var i = 0; i < val.length; i++) {
                        sum += val[i];
                    }
                    return sum/val.length;
                    break;
                }
            default:
                {
                    
                    return val[0];
                    break;
                }

        }

   return 0;

}

function HandleSolveIO(){
	var args = [];
	args[0] = "def func sum[1, 2, 3, -6]";
	args[1] = "def newList [func, 10, 1]";
	args[2] = "def newFunc sum[func, 100, newList]";
	args[3] = "[newFunc]";
	console.log(Solve(args));
}
HandleSolveIO();