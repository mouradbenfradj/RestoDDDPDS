package com.example.lenovog580.restoappnew.DB;

import java.util.Date;

/**
 * Created by LENOVO G580 on 28/01/2016.
 */
public class Reservation {

    private int ReservationId ;
    private int NombrePres ;
    public Date ResvDate ;
    public int id_resto;
    public int id_memb ;


    public int getReservationId() {
        return ReservationId;
    }

    public void setReservationId(int reservationId) {
        ReservationId = reservationId;
    }

    public int getNombrePres() {
        return NombrePres;
    }

    public void setNombrePres(int nombrePres) {
        NombrePres = nombrePres;
    }
}
