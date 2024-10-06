-- このluaスクリプトは、MA_01A110_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
se_play("SE_ambient_wind_prairie_Loop")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:勝ち気な子だったらしいですよ<br>ギネヴィア様みたいに
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100002")


	--★★ラグネル★★:アストラット領は小さく<br>他所からの侵入も容易な地形ですから…
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ラグネル★★:先祖代々、その地を守る力を<br>培ってきたと聞きます
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100004")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力

	--★★ラグネル★★:彼女自身も例外ではなかった<br>アストラット領主のご息女であるにもかかわらず
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100005")


	--★★ラグネル★★:貪欲な学習意欲で<br>文武共に並ぶものなし
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ラグネル★★:そのうえバイブスの才にも恵まれて<br>故郷を何者にも侵されない美しい地に保つ姫…
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100007")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:だから『アストラットの美姫』と呼ばれた…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_100009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:じゃあなんで今は、その…<br>なんていうか…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_100010")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:引っ込み思案になっちゃって
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたしみたいな子だったわけでしょ？<br>もっと扱いづらい子じゃないと変じゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_100012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:言いますねえ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100013")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:自分のことは承知しているつもりです
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_100014")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:ギネヴィア様はすごく変わりましたよね<br>やわらかくなったっていうか
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力

	--★★ギネヴィア★★:わたしはわたしよ<br>なあんにも変わったつもりなんてない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_100016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:変わったように見えるのはきっと──
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_100017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:ですね
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:エレインも変わっちゃったらしいです<br>今は…戻ろうとしてるのか、わかんないですけど
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100019")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "納得")
-- ▲直接出力

	--★★ギネヴィア★★:きっかけがあったワケ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_100020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:実の兄を<br>GSしてしまったから
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100021")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:………してしまった、ってなによ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_100023")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:美しい善意からだったんですよ、きっと<br>故郷を救いたいとか、家族を守りたいとか
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:でも、学園を離れた理由は<br>留学を言い訳に遠くへ行っていた理由は──
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","MA_01A110_100025")

-- ▼直接出力
se_play("SE_LoopSE_Stop")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
