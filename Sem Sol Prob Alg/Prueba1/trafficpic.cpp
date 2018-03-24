#include "trafficpic.h"
//#include "cstdlib"
//#include "ctime"
#include <QLabel>

//constructor initializing data member with image
TrafficPic::TrafficPic(){
    image.load("C:/Qt/images/Green.jpg");
    QLabel myLabel;
    myLabel.setPixmap(QPixmap::fromImage(image));
    myLabel.show();
}

//returns an image
QImage TrafficPic::getImage(){
    return image;
}
