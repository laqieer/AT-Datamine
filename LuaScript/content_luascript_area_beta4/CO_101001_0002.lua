-- このluaスクリプトは、CO_101001_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114041_01","114041_01_h")
Include("content_adv_advsmall_114041_01","Template114041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",312.6,CharaPos114041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114041_01,CameraPos114041_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114041_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName114041_01,CameraPos114041_01_004)
	InitializeTemplateRandomCamera114041_01()
	InitializeTemplate114041_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:マスター？なにか落ち着かない様子ですね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010008")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ここに来たら、どうしてもあのときのことを思い出しちゃってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:ギネヴィアたちと一緒に試験に来て…バルバロイに囲まれて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010010")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,84.5,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
set_common_look_at(Actor001,Actor002)
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:キミが現れてくれなかったらどうなっていたんだろうって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:ふふっ。私がいなくてもマスターなら切り抜けられたと思いますよ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:ええ、きっと
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:この場所今は剣の祭壇と呼ばれているのですよね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010015")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:今は、って…昔は違う呼ばれかたをしていたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい<br>名前だけではないですけれど
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010017")

	open_select_window_tag(Actor001,"Normal","CO_101001_00010018","CO_101001_00010019","CO_101001_00010020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:キミがやってくれたことに対しての
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010022")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:みんなの感謝だったり敬意の気持ちがこの祭壇なんだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:正直、俺はまだ状況をよく飲み込めてないし継承者がなんなのかすらわかってないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010024")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、マスターとしてキミにひとつお願いがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010025")

-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:私にお願い…？なんでしょう
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:これからもこの地をいや、この島のみんなを守ってやってほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:…承りました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010028")

	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:どれだけ時は流れようと私がするべきことに変わりはありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:継承者の劔としてアナタの進むべき道をともに参ります
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:この場所当時はどんな感じだったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010033")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ティルフィング", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:そうですね…今のような神聖な地ではなかったかもしれません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010034")

	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:でも、たくさんの生命がここで生まれこの清らかな水の力で育ち…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:大地へと還る前にふと戻ってみたくなるそんな素敵な地でした
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうかキミにとっても思い出深い地なんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010037")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ティルフィング", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:だからこそ…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010038")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:だからこそ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010039")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:いえ、なんでもありませんここは私にとっても大事な場所です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010040")

-- ▼直接出力
PlayPartVoice("ティルフィング", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:今日は連れてきていただいてありがとうございます、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010041")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ずいぶん長いあいだ剣としてこの地を見守っていたんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010044")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんというか、その…<br>退屈じゃなかったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010045")

-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:ふふっここにはたくさんの方がいらっしゃいましたし
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:なかには話しかけてくださる方もいて退屈と感じたことはなかったですよ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010047")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:話しかけてって…剣に向かって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:はい
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:気になるなたとえばどんなことを？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010050")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:たとえマスターであってもお答えできませんみなさんのプライベートの問題ですから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_00010051")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…それもそうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_00010052")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"ティルフィング")
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
	load_area_scene_preload(114041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
