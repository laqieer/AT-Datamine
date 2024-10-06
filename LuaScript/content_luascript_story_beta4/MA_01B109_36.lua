-- このluaスクリプトは、MA_01B109_36.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110151_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_008)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115157)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101028","001","101028001")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
DontChangeRandomCamera(true)
setup_small_camera_start(Camera090)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガラハッド…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360002")

	change_face(Actor003,"Sad")

	--★★ガラハッド★★:こ、こんばんは
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360003")

	open_select_window_tag(Actor001,"Normal","MA_01B109_360004","MA_01B109_360005","MA_01B109_360006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:声をかけてくれればよかったのに<br>いっしょに花火を見られた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360008")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:別に、いい
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360009")

	change_face(Actor003,"Normal")

	--★★ガラハッド★★:夜は冷えて仕方ない<br>スカートも、すーすーして心地が悪い
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360011")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:…この学園も<br>居心地が悪いったらない
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:行こう、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360014")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Surprise")

	--★★ガラハッド★★:ま、待て<br>スルーするな…！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360015")

	change_face(Actor003,"Normal")

	--★★ガラハッド★★:ガラハッドには<br>聞きたいことがあるんだ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:フィエナはいっしょじゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360019")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:姉上は慣れぬ聖杯探知がこたえたのか<br>休養を取っている
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360020")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:ガラハッドは、その…<br>ぴかぴか夜空が綺麗だから、出て来た
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360021")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:聞かせてほしい、ノワール
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360023")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力

	--★★ガラハッド★★:…『ブルーノ』というのか
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360024")

	open_cutin(2,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor002,"Surprise")
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:お前の父…<br>『妖精殺し』の名前は
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360026")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…聞いていたのか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_360027")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ガラハッド★★:ガラハッドは目を離さない<br>以前に学園へ来たのも本来はそのためだった
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:コルベニック城のみんなを<br>助けるためじゃなかったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360029")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:最強の騎士<br>『ランスロット』を学ぶためだ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360030")


	--★★ランスロット★★:…俺に学ぶべきところなどない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_360031")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:忘れたか<br>『ガラハッド』は…<ruby=ランスロット>あなた</ruby>の幼名だ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360032")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360034")


	--★★ランスロット★★:…なぜ自分の幼名を名乗る騎士が現れたのか<br>もちろん驚きはしたが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_360035")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力

	--★★ガラハッド★★:<ruby=ガラハッド>幼名</ruby>を捨てた理由はわからないが<br>いつしかあなたは<ruby=ランスロット>今の名</ruby>で騎士を目指し始めた
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360036")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガラハッド★★:そしてその名を…ガラハッドの名を<br>ぺレスお爺様は別の子供につけられた
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360038")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力

	--★★ガラハッド★★:「ランスロットこそ最強の騎士<br>目指すべき誉れ高い指針」
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360039")


	--★★ガラハッド★★:いずれはそうなるべきと<br>きっとお爺様は祈りを込めたんだ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360040")


	--★★ランスロット★★:…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_360041")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:ガラハッドは考えていた、ずっと考えていた<br>これから自分がどうあるべきか
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360042")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力

	--★★ガラハッド★★:ガラハッドは、<dot>本当</dot>が知りたい
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360043")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:本当が、知りたい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360045")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:ノワールが『妖精殺し』の軌跡をなぞるなら<br>ガラハッドはともに行く
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360046")


	--★★ガラハッド★★:<ruby=シルバタブラナイツ>銀卓騎士団</ruby>のルーツを知り<br>現在の彼らと向き合うために
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360047")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力

	--★★ガラハッド★★:そしてランスロット<br>あなたの<dot>本当</dot>を見極める
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360049")


	--★★ガラハッド★★:お爺様はどうなれと言いたかったのか<br>ガラハッドが辿る騎士道はどうあるべきか
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360051")

	open_select_window_tag(Actor001,"Normal","MA_01B109_360052","MA_01B109_360053","MA_01B109_360054")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…よろしく頼む
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360056")

	change_face(Actor003,"Normal")

	--★★ガラハッド★★:あくまでガラハッドの仲間は銀卓騎士団だ<br>お前たちとなれ合う気はない
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360057")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:けれどひとまずは…<br>こちらこそよろしく
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360058")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キミの目指すものに辿り着ける保証はないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360060")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺もお前が期待するようなものを<br>見せてやれるとは思わないが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_360061")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それでも良ければ<br>好きにしたらいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360062")

	change_face(Actor003,"Normal")

	--★★ガラハッド★★:そうさせてもらう
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360063")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:…ひとこと付け加えさせてもらう<br>過度な干渉は遠慮願う
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360064")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…俺も同じだったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360066")

	change_face(Actor003,"Normal")

	--★★ガラハッド★★:どういう意味だ？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360067")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:本当が知りたい<br>その気持ち、わかるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_360068")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Surprise")

	--★★ガラハッド★★:が、がら、ガラハッドの、なにがわかると…？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360070")

	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:ガラハッドは探すんだ<br>本当を知り、学びを得て
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360072")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力

	--★★ガラハッド★★:自分の脚で向かう先を
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_360074")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115157)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101028","001","101028001")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
