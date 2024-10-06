-- このluaスクリプトは、MA_01B109_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera005 = SetTemplate("Actor005",-37.4,CharaPos112021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116024)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:王妃様が先陣に立つのよこの意味おわかり？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060038")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:超ヨユーで勝てるってことよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060039")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ギネヴィア★★:円卓の騎士がゴネたらいつでも言って<br>わたしがガツーンとシメたげるから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to Bow")
-- ▼直接出力
 --PlayPartVoice("市民_男2", "肯定3")
-- ▲直接出力

	--★★市民（男）★★:悩みを聞いていただきありがとうございました<br>王妃様
	Talk(Actor003,"NPCNAME_0145","speech","N","MA_01B109_060003")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Appear(Actor001)
Hide(Actor003)
Hide(Actor005)
Hide(Actor006)
wait_time(CHARA_IN_WAIT)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_060004","MA_01B109_060005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ<br>みんなの相談に乗ってあげてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_060007")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あっノワール！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060008")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネマウア★★:殿下は定期的にこうやって<br>街の人の話を聞いているんです
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","MA_01B109_060010")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたしにできることなんて<br>これくらいだしね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:体はもう大丈夫なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_060013")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:だいじょーぶ、だいじょーぶ<br>心配いらないわ。ほら！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060014")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そんなことよりこれからのことよ！<br>あなたの働き、期待させてよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060016")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたしはノワールや円卓の騎士みたいに<br>強くないからわかるような気がするの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060018")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:街のみんなの不安な気持ち
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_060020","MA_01B109_060021")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアも強いよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_060023")

	change_face(Actor001,"Normal")

	--★★ノワール★★:本当に弱い人間は<br>他人の不安を和らげてやろうなんて考えない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_060024")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:足がすくんで手が震えてるのに<br>父親を救おうなんて考えない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_060025")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ノワール…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:街の人たちもそれを知ってるから<br>キミに相談しに来ているんだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_060027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:うん、ありがとう
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060029")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:さすがギネヴィア<br>俺も負けてられないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_060031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうね<br>なんたって継承者様だもん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:必ず守ってみせるよ<br>学園のみんなを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_060033")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…うん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060034")

	goto Block2end

::Block2end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:頑張んないとね<br>あなたは継承者、わたしは王妃として
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060036")


	--★★ギネヴィア★★:ただの飾りでいられない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_060037")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116024)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
