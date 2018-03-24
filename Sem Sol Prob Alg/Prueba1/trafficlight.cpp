#include "trafficlight.h"
#include <QGridLayout>
#include <QMessageBox>
#include <stdlib.h>
#include <time.h>

//constructor
TrafficLight::TrafficLight(){
    //initializes the timer
    timer = new QTimer(this);
    //sets up the GUI
    setUpGUI();
}

//sets up the GUI and connects signals and slots
void TrafficLight::setUpGUI(){
    //initializes all the widgets
    timerLabel = new QLabel("Set Timer [Range: 2000 - 10000 ms] ");
    timerEdit = new QLineEdit();
    okButton = new QPushButton("Set Timer");
    image = new QImage();
    cancelButton = new QPushButton("Cancel");

    //creates a layout and places widgets on the layout
    QGridLayout* layout = new QGridLayout();
    layout->addWidget(timerLabel, 0, 0);
    layout->addWidget(timerEdit, 0, 1);
    layout->addWidget(okButton, 1, 1);
    layout->addWidget(image, 2, 1);
    layout->addWidget(cancelButton, 3, 1);
    //layout is set to the root widget
    this->setLayout(layout);
    //title of the root widget is set
    this->setWindowTitle("Traffic Light");

    //signals and slots are connected
    connect(okButton,SIGNAL(clicked()), this, SLOT(setTimer()));
    connect(cancelButton, SIGNAL(clicked()), this, SLOT(cancelTimer()));
    connect(timer, SIGNAL(timeout()),this, SLOT(displayImage()));
}

//checks if the user input is valid and starts the timer
void TrafficLight::setTimer(){
     bool ok;
     QString timerText = timerEdit->text();
     int timerValue = timerText.toInt(&ok, 10);

     if (ok && (timerValue >= 2000) && (timerValue <= 10000)){
         timer->setInterval(timerValue);
         timer->start();
         timerEdit->setReadOnly(true);
         okButton->setDown(true);
     }
     else{
         QMessageBox:: information(this, "Invalid timer value", "Invalid or out of range timer value.");
     }
}

//display the image
void TrafficLight::displayImage(){
    tf.getImage();
}

//stops the timer and allows user to reset the timer
void TrafficLight::cancelTimer(){
    timer->stop();
    okButton->setDown(false);
    timerEdit->clear();
    timerEdit->setReadOnly(false);
}
