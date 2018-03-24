#ifndef PASANJERSFLIGHTVIEW_H
#define PASANJERSFLIGHTVIEW_H

#include <QDialog>

namespace Ui {
class PasanjersFlightView;
}

class PasanjersFlightView : public QDialog
{
    Q_OBJECT

public:
    explicit PasanjersFlightView(QWidget *parent = 0);
    ~PasanjersFlightView();

private:
    Ui::PasanjersFlightView *ui;
};

#endif // PASANJERSFLIGHTVIEW_H
