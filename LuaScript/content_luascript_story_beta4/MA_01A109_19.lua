-- このluaスクリプトは、MA_01A109_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115094)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ラシア★★:敬虔ですね
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:静かなので、ここは
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_190004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:考えごとをするときに…
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190005")


	--★★エレイン★★:…丁度、良いです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_190006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:『アストラットの美姫』は<br>なにを悩むのですか？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力

	--★★エレイン★★:不釣り合いな名前です、私には
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_190008")


	--★★ラシア★★:エレイン<br>あなたはなぜ学園に？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:いるべきじゃ、ないんです<br>ここには
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_190010")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定3")
-- ▲直接出力

	--★★ラシア★★:その力を<br>活かそうとはしないんですか？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190011")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:ありません、力なんて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_190012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラシア★★:強い人というのは<br>香るから
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190014")


	--★★ラシア★★:誰にも侵されはしない臓腑があるという確信…<br>…それは自覚的には抑えられず、鼻につく
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:………ラシアさん<br>あなたはどうして学園に？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_190016")

-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:恩に報いるため<br>返さなければならない義理があるんです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190017")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:いいえ。あったんです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:エレイン、あなたの言った通り<br>今は状況が変わってしまったから
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190021")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ラシア★★:だけどもしかしたら<br>あの人自体は変わっていないのかもしれません
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:なら、余計に…なにも<br>飲み込むことができなくて
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190023")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:同じ、ですね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_190025")

-- ▼直接出力
 --PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:………同じ？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_190026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:一生をかけて返す義理が、あるから<br>なにも、私はなにも…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_190027")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:うまく、口にできなくて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_190028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115094)
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
