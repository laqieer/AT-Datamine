-- このluaスクリプトは、CO_101012_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111091_01","111091_01_h")
Include("content_adv_advsmall_111091_01","Template111091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_003)
	InitializeTemplateRandomCamera111091_01()
	InitializeTemplate111091_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001, 0)
turn_lookat(Actor001,Actor002, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:里を離れてからしばらく経つけど<br>変わらないでいてくれてホッとするな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力

	--★★ディナタン★★:そうだね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:兄さんが登って下りられなくなった木も<br>兄さんが落ちそうになった井戸もそのまま
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010010")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ディナタンが母さんを怒らせて<br>閉じ込められた納屋もそのままだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010011")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:あれは兄さんのせいで<br>私が怒られたんだからね！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:違う違う！<br>あれは正確にはブライアンの悪戯なんだよ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…プッ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010014")

-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははは！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010015")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.7)
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なあ、ディナタン<br>ときどきはここに来てさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010016")


	--★★ノワール★★:里を守っていかないか？<br>俺たちのできるかぎりで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:うん、賛成<br>喜ぶと思うよ、みんな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…さてと！<br>このあとはどうしようか？兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010019")

	open_select_window_tag(Actor001,"Normal","CO_101012_00010020","CO_101012_00010021","CO_101012_00010022")
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
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:じゃあ、弁当でも食べるか<br>作って来てくれたんだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:ふっふっふ…今回は自信作だよ～<br>彩りもバッチシ！ボリュームも栄養も満点！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010025")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:じゃーん！どう？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010026")

	PlayAction(Actor001,"to  Std_Appl")
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:おお、確かに美味そうだ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…この赤いのさえなければ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010028")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:好き嫌いはダメだよ、兄さん<br>トマトも食べるの！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:母さんの墓参りに行こう<br>しばらく来れてなかったからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:うん。そうだね<br>まずは元気な顔を見せてあげなくちゃ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010032")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:色々あったし、きっと心配してるよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:確かに…色々ありすぎたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010034")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:ランス兄ちゃんのこととかもお話して…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010035")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:それからお墓にお花を供えてあげよう<br>――母さんの好きだった、お花
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010036")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:少しゆっくりしていかないか？<br>木陰で昼寝でもしてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010040")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:たまにはこういうのもいいだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:お疲れだねぇ、兄さん<br>私は別に大丈夫だけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010042")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:でも兄さん、平気なの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010043")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:その木、よく上から毛虫落ちてくるよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_00010045")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:帰ろう、帰ろう。今すぐ帰ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_00010046")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"ディナタン")
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
	load_area_scene_preload(111091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
