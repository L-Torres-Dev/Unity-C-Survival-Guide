using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    float quizGrade1;
    float quizGrade2;
    float quizGrade3;
    float quizGrade4;
    float quizGrade5;

    private void Start()
    {
        quizGrade1 = UnityEngine.Random.Range(0, 100f);
        quizGrade2 = UnityEngine.Random.Range(0, 100f);
        quizGrade3 = UnityEngine.Random.Range(0, 100f);
        quizGrade4 = UnityEngine.Random.Range(0, 100f);
        quizGrade5 = UnityEngine.Random.Range(0, 100f);

        float average = (quizGrade1 + quizGrade2 + quizGrade3 + quizGrade4 + quizGrade5) / 5;

        print($"grade 1: {quizGrade1}");
        print($"grade 2: {quizGrade2}");
        print($"grade 3: {quizGrade3}");
        print($"grade 4: {quizGrade4}");
        print($"grade 5: {quizGrade5}");

        print("Average Grade: " +  average);
    }
}