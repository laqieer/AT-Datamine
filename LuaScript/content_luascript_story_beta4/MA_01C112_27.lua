-- このluaスクリプトは、MA_01C112_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_001)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:よお、継承者
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:神頼みでもしにきたか<br>アーサーのヤロウに勝つために
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270003")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("クラリス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:あらっ、ノワールくんもですかぁ？<br>奇遇ですね！わたしもお祈りしてるんです
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C112_270004")

-- ▼直接出力
 --PlayPartVoice("クラリス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:モルくんがアーサー様に勝てますようにって
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C112_270005")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003, 0.44)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:おめえは黙ってろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270006")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:つか、あいつに<dot>様</dot>なんてつけんな<br>もうこの国の王じゃねえんだからよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270007")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "悲しみ")
-- ▲直接出力

	--★★モルドレッド★★:結局あいつは偽の王だったんだ<br>正道から外れ、力に飲まれちまった
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:だから真の王であるオレが<br>アーサーのヤロウをぶっ潰さなきゃならねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270010")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("クラリス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:でも、モルくん<br>わたしたちは…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C112_270011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★モルドレッド★★:おめえは黙ってろって言ってんだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270012")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力

	--★★モルドレッド★★:…わかってんだよ<br>おめえがなにを言いてえかくらい
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001, 0.44)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.33)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:だからオレはてめえと組んでやる<br>どうだ？いい話だろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270015")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:どうせてめえらだけじゃ<br>あのヤロウには歯が立たねえんだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C112_270017","MA_01C112_270018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ああ、そのとおりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_270020")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:なんだぁ？<br>ずいぶん弱気じゃねえか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270021")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:チッ…組む相手間違えたか？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:自分だってそうだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_270024")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:へっ、言うじゃねえか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270025")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クラリス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:モルくんもさっき<br>そう言いかけましたもんねぇ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C112_270026")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:黙ってろって言ってんだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270027")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…どうすれば、アーサーに勝てるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_270029")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:それがわかれば、わざわざ<br>てめえなんかと組む必要はねえよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270030")

	PlayAction(Actor002,"to  Std_Worry")

	--★★モルドレッド★★:バルバロイを率いて、魔女を従え<br>聖杯を破壊し、なに考えてやがるんだかな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270031")


	--★★モルドレッド★★:けどヤロウ自身は…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうした？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_270034")

	PlayAction(Actor002,"to  Std_No")

	--★★モルドレッド★★:…いや、なんでもねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:とにかくオレはアーサーのヤロウをぶっ倒す<br>そのための方法を探さなきゃならねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270037")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:ずいぶんこだわるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_270038")

	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:あ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:あんたはずっと<br>アーサーを倒すことだけにこだわってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_270040")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:それのなにがおかしい<br>オレはずっとヤロウのことが気に入らねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270041")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:気に入らねえからぶっ飛ばして<br>オレが真の王になる。それだけだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")

	--★★モルドレッド★★:…てめえがやってきたことを貫かねえ<br>腑抜けの王なんていらねえって話だよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270043")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:モルドレッド…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_270045")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:真の王が偽の王に引導を渡す
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Serious")

	--★★モルドレッド★★:てめえにも役に立ってもらうぞ<br>継承者?
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_270048")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
