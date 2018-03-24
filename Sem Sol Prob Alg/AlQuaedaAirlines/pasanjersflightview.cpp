#include "pasanjersflightview.h"
#include "ui_pasanjersflightview.h"

PasanjersFlightView::PasanjersFlightView(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::PasanjersFlightView)
{
    ui->setupUi(this);
}

PasanjersFlightView::~PasanjersFlightView()
{
    delete ui;
}
