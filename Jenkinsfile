pipeline {
    agent any

    stages {
        stage('Cloner le Repository') {
            steps {
                git "https://github.com/BADREED0/QuadraticSolver.git"
            }
        }

        stage('Compiler l\'application C') {
            steps {
                script {
                    // Vous pouvez ajouter des étapes pour installer des dépendances si nécessaire
                    dir(QuadraticSolver){
                        bat "dotnet build --configuration Release"
                    }  
                }
            }
        }

    }

}
