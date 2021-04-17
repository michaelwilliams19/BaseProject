using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fw.BE;
using Imp.BE;
using System.Collections.Specialized;
using fw.Interfaces;

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
