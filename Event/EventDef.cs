using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class EventDef
{
    #region ϵͳ��Ϣ 1-1000
    
    public const int ResLoadFinish = 1;

    #endregion

    #region ���������Ϣ 2000 - 4000

    /// <summary>
    /// ���ñ�������
    /// </summary>
    public const int TableDataFinish = 2000;

    #endregion

    #region ս������¼� 5000 - 6000

    /// <summary>
    /// ״̬������Ϣ
    /// </summary>
    public const int StateEndEvent = 5000;

    /// <summary>
    /// ���н�ɫ�������
    /// </summary>
    public const int CreateRoleFinsh = StateEndEvent + 1;
  
    #endregion


}
