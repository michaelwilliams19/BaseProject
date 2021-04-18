using System;
using Imp.Entities;
using System.Collections.Specialized;

namespace Imp.ValidatorBE
{
    public class TurnoBEValidator : ValidatorAbstracto<TurnoBE>
    {
        public override NameValueCollection Validar(TurnoBE BE)
        {
            if (BE.usuarioID == null)
                valueValidator.Add("1", "Debe seleccionar un medico para registrar el turno");

            if (BE.pacienteID == null)
                valueValidator.Add("2", "Debe seleccionar un paciente para registrar el turno");

            if (Convert.ToDateTime(BE.fechaTurno) < DateTime.Now)
                valueValidator.Add("3", "Ya ha pasado la fecha seleccionada. Debe elegir una fecha posterior al dia de hoy");

            return valueValidator;
        }
    }
}