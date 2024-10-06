-- このluaスクリプトは、MA_01B109_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_02_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.08
--setup_small_camera_resetting(Actor003,{CharaPos110141_02_001[1]-arufa,CharaPos110141_02_001[2],CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115144)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to Greet_one")

	--★★モルガン★★:おはよう。旅人さん
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B109_110002")


	--★★ガラハッド★★:………ここは
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_110003")

-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:留学の面接は突破ね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B109_110004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★モルガン★★:倒れちゃったのは精神的な疲れによるものね<br>それもかなり重いストレス…
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B109_110005")

	change_face(Actor004,"Normal")

	--★★モルガン★★:もう少しゆっくり休んでいて
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B109_110006")

	change_face(Actor003,"Anger")

	--★★ガラハッド★★:姉上は！？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_110008")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:ふぃ、フィエナだったら<br>アーサー様にお話があるって言って…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_110009")


	--★★ガラハッド★★:そうか、失礼する！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_110010")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ディナタン★★:ま、待って…！<br>まだあんまり動いちゃ──
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_110012")

-- ▼直接出力
PlayAction(Actor001,"to Sit01_BA01")
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力

	--★★ガラハッド★★:触るな！！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_110014")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01B109_11_Slap")
shake_camera(Camera001, 1.0, 0.2)
wait_time(1.0)
change_face(Actor001,"Sad")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:………あ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_110016")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…！<br>あ、ご、ごめんなさい…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_110017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:…す、すまない<br>他人に触れられると、つい…！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_110018")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★モルガン★★:こら。ディナタンは看病してくれたのよ？<br>トリスタン卿を追っ払ってまで
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B109_110019")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガラハッド★★:え…っ<br>あのオカッパを…？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_110020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルガン★★:言いかた
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B109_110021")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:礼が聞こえねェなア
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B109_110023")


	--★★ガラハッド★★:ひっ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_110025")


	--★★マルディサント★★:鎧の外し方わかんねえから<br>テメーをベッドに上げるの苦労したんだぜ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B109_110026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:マァル、いいの<br>とりあえず目を覚ましてくれてよかった
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_110027")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:………面倒を、かけた
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_110029")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
turn(Actor001,0,246.2557,0,0)
wait_time(0.2)
lookat_delay_weight(Actor001, 1.0, 0.1, 0.5, 0.2,0.5)
keep_delay_ik_lookat(Actor001,Actor002,"J_Neck",1.0) --喉あたり注視
Hide(Actor003)
off_active(huton)
se_play("SE_ADV_MA_01B109_11_Door")
wait_time(CHARA_IN_WAIT)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:…マァァルぅ～
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_110031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 1.0,0.08,0.5,0,0.8)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
PlayAction(Actor002,"to  Std_Surp")
 --PlayPartVoice("マルディサント", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:あ、アタシのせいかぁ…！？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B109_110032")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:元気でよろしい<br>どこも病んではいなかったわ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B109_110033")


	--★★モルガン★★:あとはお兄さんがたに<br>お任せしてしまいましょお
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B109_110034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:またオニーサンが<br>苦労すんじゃねえの
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B109_110035")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:ふふ…そうかもね<br>でもランス兄ちゃんもついてる
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_110036")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:きっと、だいじょうぶだよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B109_110037")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力

	--★★マルディサント★★:…ディーナがそう言うなら<br>まあ、いいけど難儀するぜ多分
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B109_110038")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 0.6)
-- ▲直接出力

	--★★マルディサント★★:心までガッチリ<br>鎧、着込んじまってさ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B109_110039")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115144)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
