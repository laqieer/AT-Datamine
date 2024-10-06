-- このluaスクリプトは、MA_01C109_23.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110171_08","110171_08_h")
Include("content_adv_advsmall_110171_08","Template110171_08_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110171_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110171_08,CameraPos110171_08_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110171_08_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110171_08,CameraPos110171_08_002)
	InitializeTemplateRandomCamera110171_08()
	InitializeTemplate110171_08()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115174)
	Actor001 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("フレン","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フレン★★:おこがましかったかな
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01C109_230002")

-- ▼直接出力
 --PlayPartVoice("ラシア","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:なにが？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01C109_230003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★フレン★★:雲の上の存在を知ろうだなんて
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01C109_230004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:…皇太子殿下のこと？しょうがないよ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01C109_230006")

-- ▼直接出力
 --PlayPartVoice("フレン","挨拶")
-- ▲直接出力

	--★★フレン★★:叔父様が恋しい？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01C109_230008")

	PlayAction(Actor002,"to  Std_No")

	--★★ラシア★★:………相手にされてなかったのかも
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01C109_230010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フレン★★:私も、同じく
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01C109_230012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フレン★★:…情けないな妹だけが頼みの綱だなんて
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01C109_230013")

-- ▼直接出力
 --PlayPartVoice("ラシア","悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラシア★★:ローラは──…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01C109_230015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フレン★★:行っちゃったルーシャスくんを連れ戻すんだって
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01C109_230016")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:止めなかったの？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01C109_230017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★フレン★★:止める間もなく
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01C109_230018")


	--★★フレン★★:どこに行ったかもわからない<br>追いかけられもしないよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01C109_230020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フレン★★:だから待っててあげなきゃ、信じて
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01C109_230021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115174)
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110171_08)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
