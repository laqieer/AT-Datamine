-- このluaスクリプトは、MA_01104_201.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",216.1323,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_pos(Actor001,{7.21,0,14.46})
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Comical")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("山賊", "怒り")
-- ▲直接出力

	--★★ガラの悪い男★★:あぁ？おい、ガキ<br>そんなんで謝ってるつもりかぁ！？
	Talk(Actor003,"NPCNAME_0257","speech","N","MA_01104_2010001")

-- ▼直接出力
PlayPartVoice("ラロゥ", "苦しみ")
-- ▲直接出力

	--★★ラロゥ★★:す、すみません…
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010002")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男1", "照れ")
-- ▲直接出力

	--★★偉そうな男★★:だ～か～ら～、口だけじゃなくて<br>出すもの出せって言ってんの。わかる？
	Talk(Actor004,"NPCNAME_0371","speech","N","MA_01104_2010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
Appear(Actor001)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:それは…
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010004")

-- ▼直接出力
PlayActionDirect(Actor001,"to Run")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,{-1.36,0,2.241},2.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.9)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,204,0,0.1)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:やめろ！<br>あんたたち、なにしてるんだ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010006")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "肯定2")
-- ▲直接出力

	--★★ガラの悪い男★★:誰だ、テメェ…？<br>オレたちはこいつに教育してやってるところだよ
	Talk(Actor003,"NPCNAME_0257","speech","N","MA_01104_2010007")


	--★★ガラの悪い男★★:このガキがオレにぶつかってきやがったからよ～<br>謝罪の仕方を教えてやってんだよ
	Talk(Actor003,"NPCNAME_0257","speech","N","MA_01104_2010008")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ぶつかったって…本当か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "悲しみ")
-- ▲直接出力

	--★★ラロゥ★★:…はい、ぶつかったのは本当です<br>でも、そんなに勢いよくじゃ…
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010010")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:確かにあんた<br>ケガをしているようには見えないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010011")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("山賊", "肯定2")
-- ▲直接出力

	--★★ガラの悪い男★★:…うるせぇんだよ！<br>イテェっつったらイテェんだよ！
	Talk(Actor003,"NPCNAME_0257","speech","N","MA_01104_2010012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラの悪い男★★:文句があるならテメェがこのガキの代わりに<br>治療費払えや！
	Talk(Actor003,"NPCNAME_0257","speech","N","MA_01104_2010013")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やれやれ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101065_0502_Chop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C900_19_Punch")
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Angry")
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "苦しみ")
-- ▲直接出力

	--★★ガラの悪い男★★:クソッ、覚えてやがれー！
	Talk(Actor003,"NPCNAME_0257","speech","N","MA_01104_2010018")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "落胆")
-- ▲直接出力

	--★★偉そうな男★★:これで勝ったと思うなよ～！
	Talk(Actor004,"NPCNAME_0371","speech","N","MA_01104_2010019")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,201.2296,0,0.2)
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,186.2417,0,0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.14)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Run")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003,{-3.634,0,-4.959},1.6)
-- ▲直接出力
-- ▼直接出力
wait_time(0.06)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Run")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor004,{-2.934,0,-4.88},1.6)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:あいつら…全然元気じゃないか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010021")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,178,0,0.7)
-- ▲直接出力
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:災難だったな、大丈夫か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010022")

-- ▼直接出力
bgm_play("BGM_ADV_Comical")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力

	--★★ラロゥ★★:…あーあ、あとちょっとだったのになー
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010024")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？<br>なにがだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010025")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,343.6459,0,0.7)
-- ▲直接出力
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:なにがってお金だよ、オ・カ・ネ
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010026")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ラロゥ★★:あと少しアイツらが近づいてくれれば<br>お金盗れたのに
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010027")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:な…！<br>まさかぶつかったっていうのも！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:そ。でも見かけによらず厳重に持ってたから<br>取り損ねちゃってさ
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010029")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:ま、オニーサンのおかげで助かったよ<br>ありがと
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010030")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力

	--★★ノワール★★:お前…！さっきまでと態度と言葉遣いが<br>全然違うじゃないか！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010031")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ああ、あんなのフリだよフリ<br>弱そうにしてたら親切な大人が助けてくれるだろ
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010032")

-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:オニーサンみたいな、さ
	Talk(Actor002,"NPCNAME_0370","speech","L","MA_01104_2010033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ハァ<br>お前、名前は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010034")

-- ▼直接出力
--ラロゥ,CHRNAME_LAROU @名前変更
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:オレ？オレはラロゥ。盗賊やってんだ<br>オニーサンは？なんて名前？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","MA_01104_2010035")


	--★★ノワール★★:…ノワール
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力

	--★★ラロゥ★★:ノワールね<br>じゃ、また街でオレが困ってたら助けてよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","MA_01104_2010037")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:いや…助けてくれるよね？<br>親切なノワール
	Talk(Actor002,"CHRNAME_LAROU","speech","L","MA_01104_2010038")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:やれやれ…<br>厄介なヤツと知り合いになっちゃったかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_2010039")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Comical")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
