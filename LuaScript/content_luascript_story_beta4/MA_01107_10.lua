-- このluaスクリプトは、MA_01107_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
load_image("102010060_StillImage", "content_still_10201006_image", "102010060_StillImage")
DontChangeRandomCamera(true)
PlayActionDirect(Actor002,"to baptism01")
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor001)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:ん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100002")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_100004")

-- ▼直接出力
CameraEX = set_camera({1.05,2.05,1.4,15,163,0,16})
setup_small_camera_start(CameraEX)
slidemove(CameraEX,{1,2.05,1.4},7.0)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わかるでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100006")

	open_select_window_tag(Actor001,"Normal","MA_01107_100008","MA_01107_100009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Angry")
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ちょっと！！<br>どけないでよ！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01107_100011")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ウワア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_100012")

-- ▼直接出力
CameraEX = set_camera({1.05,2.05,1.4,15,165,0,16})
setup_small_camera_start(CameraEX)
slidemove(CameraEX,{1,2.05,1.4},7.0)
lookat_weight(Actor001,0.7,0.03,0.7,0)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:なんで無言でどけちゃうの！？<br>行間を読め！意味を深読みしなさいよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Surp")
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ひゃああああああっ！？！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01107_100015")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ウワア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_100016")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
CameraEX = set_camera({1.05,2.05,1.4,15,165,0,16})
setup_small_camera_start(CameraEX)
slidemove(CameraEX,{1,2.05,1.4},7.0)
lookat_weight(Actor001,0.7,0.03,0.7,0)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:ち、ちがうの！ちがうのよ！<br>そういうことを求めていたんじゃないんだなあ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:でも、でもまあいいわ！うんうんうんうん<br>これはこれでいいわ！合格！オッケー！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100020")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
reserve_eyesync(Actor002,"Close")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:気を取り直して
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100022")

	PlayAction(Actor003,"to Bow")
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:騒がしくて申し訳ございません
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_100023")

-- ▼直接出力
reserve_eyesync(Actor002,"Auto")
-- ▲直接出力

	--★★ギネヴィア★★:補講の対価を徴収していなかったなと思ってね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100024")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ゆ、有料講習だったのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_100025")

	PlayAction(Actor003,"to  Std_No")

	--★★ギネマウア★★:申し訳ございません<br>殿下がケチで
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_100026")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:なんとでも言いなさい！<br>労働力を無料で差し出しはしないわ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100027")

	change_face(Actor001,"Sad")

	--★★ノワール★★:えーと<br>対価って…どうすれば？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_100029")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ルーシャス皇太子殿下に話つけにいくんでしょ？<br>「我らログレスにお助けを」って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100031")

-- ▼直接出力
CloseTalkWindow()
show_image("102010060_StillImage", 0.0, 0.0, STILL_SWITCH_TIME ,false,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:ただ、私の調べによりますと皇太子殿下は<br>数日前より<ruby=ロンディニウム>ローマの都</ruby>へ行かれているそうで
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","simple","N","MA_01107_100032")


	--★★ギネヴィア★★:無断欠席、不登校<br>留学生なのに生意気ね
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01107_100034")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME) 
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:出発は明日にしましょ！ノワール<br>対価はずばり──…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100035")

-- ▼直接出力
CameraEX = set_camera({1.05,2.05,1.4,15,165,0,16})
setup_small_camera_start(CameraEX)
slidemove(CameraEX,{1,2.05,1.4},7.0)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Finger")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わたしを<ruby=ローマ>観光</ruby>につれてって？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_100037")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010060_StillImage", "content_still_10201006_image", "102010060_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
