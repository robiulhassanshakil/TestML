using ManualModelTrain;

//MLModel1.Train(@"D:\Office Code\SJ\Microsoft_ML_DotNet\TestML\ManualModelTrain\MLModels\TestModelName1.mlnet");

//var result = MLModel1.Predict(horizon: 48);

//var count = 0;
//foreach (var item in result.Energy_use)
//{
//    count++;
//    Console.WriteLine($"{count} = {item}");
//}

MLModel1.Evaluate();