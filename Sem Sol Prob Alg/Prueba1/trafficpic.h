#ifndef TRAFFICPIC_H
#define TRAFFICPIC_H

#include <QImage>

class TrafficPic{
public:
    //no-arg constructor
    TrafficPic();
    //returns an image
    QImage getImage();
private:
    //to store image
    QImage image;
};
#endif // TRAFFICPIC_H
