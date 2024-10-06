-- このluaスクリプトは、MA_01B900_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",332.888,CharaPos110141_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor002,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115150)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力

	--★★モルガン★★:隠さなくたっていいのよ？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050002")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガラハッド★★:………え
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050003")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:サボりに来たんでしょう！
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:よーこそー
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B900_050005")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:ああ～マァルと付き合ったばっかりに<br>ガラハッドが悪い子になっちゃった
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_050006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガラハッド★★:………ああ。そのようだ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050007")

-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力

	--★★モルガン★★:ありがとう、ガラハッド<br>帰って来てくれて
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050009")


	--★★ガラハッド★★:約束、したから…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050010")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:それに…ガラハッドは結局<br>大したことも出来ぬまま、おめおめと…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:大したことなんてしなくていいのよ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050012")

	change_face(Actor004,"Smile")

	--★★モルガン★★:家族はただ<br>無事で帰って来てくれれば
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050013")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:そーだぜ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B900_050014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:貴方は大したものだけどね？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:継承者と最強騎士様と一緒に<br>死線をくぐり抜けたんだもんね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_050016")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:…ガラハッドは<br>うまくできているだろうか
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050017")


	--★★モルガン★★:言ったでしょう？<br>貴方は自分の魅力に気づいたほうがいいって
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050018")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:自分を好きになってあげて
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050019")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ガラハッド★★:………あ、う…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★モルガン★★:…どうしたの？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050021")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:伝えたいことが、あったんだ…<br>あなたに言わなければならないことが
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050022")

-- ▼直接出力
 --PlayPartVoice("モルガン", "納得")
-- ▲直接出力

	--★★モルガン★★:ああっ、私もあったわ<br>貴方に伝えなきゃならないことが
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガラハッド★★:なんだ…？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050024")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:アーサーを守ってくれて<br>ありがとうって
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050025")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:………っ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050026")

-- ▼直接出力
CloseTalkWindow() --疑似バトルならclose_speech_window(
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:ど、どうしたのガラハッド…？<br>どこか、どこか痛いの…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_050028")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:あぁ、ぐすっ<br>うぅぅぅ、うううううっっ…!!
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050029")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:なに、泣いてんだよぉ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B900_050031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力

	--★★モルガン★★:ずっとガンバって来たから<br>ホッとしちゃった？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050033")

	PlayAction(Actor003,"to  Std_No")

	--★★ガラハッド★★:ううううっ、そう、じゃない…っ<br>そうじゃない、んだ…っっ！僕は──…！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B900_050034")

-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力

	--★★モルガン★★:強がらなくたって<br>ガラハッドは強いわ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B900_050035")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115150)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
