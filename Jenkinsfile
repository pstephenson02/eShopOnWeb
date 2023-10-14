pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building'
                dotnetBuild
            }
        }
        stage('Test') {
            steps {
                echo 'Testing'
                dotnetTest
            }
        }
    }
}
