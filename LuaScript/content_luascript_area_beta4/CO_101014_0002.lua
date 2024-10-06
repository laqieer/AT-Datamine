-- このluaスクリプトは、CO_101014_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114021_01","114021_01_h")
Include("content_adv_advsmall_114021_01","Template114021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_005)
	InitializeTemplateRandomCamera114021_01()
	InitializeTemplate114021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:まさかキミとこんな風にこの海を眺めることになるなんてね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010008")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,153.8,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
set_common_look_at(Actor001,Actor002)
PlayPartVoiceDirect("ノワール","0002")
-- ▲直接出力

	--★★ノワール★★:なんだよイヤだったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★トリスタン★★:そうは言ってないでしょま、嫌じゃないとも言ってないけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010010")


	--★★トリスタン★★:…ここは、昔からよーく知っているところだから
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:そうなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:知り合いがここに住んでいてね居候していた時期があるんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010013")


	--★★トリスタン★★:ボクが竪琴に興味をもつようになったのも<br>その知り合いのおかげだよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ひょっとしてトリスタンが持ってる竪琴も<br>その人から貰ったとか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010015")

-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_delay_weight(Actor002, 0.6, 0.5,0.8, 0.5,1.0)
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★トリスタン★★:へえ…キミにしては鋭いじゃないか
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺にしてはって…褒めてないな、それ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:鋭いね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010018")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:なんにしても、変な感じだよここをキミと今一緒に歩いてるなんて
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101014_00010020","CO_101014_00010021","CO_101014_00010022")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
voice_play("VO_101009_sp_0006_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なあ、トリスタン俺のこと、まだ疑ってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010024")

	change_face(Actor002,"Surprise")

	--★★トリスタン★★:は？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Serious")

	--★★トリスタン★★:逆に聞くけど<br>キミは疑いが晴れたと思っているわけ？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010026")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:思っている…というかお前に疑われるようなことはしてないつもりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010027")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:はあ。どうにも調子が狂うよねキミと話していると
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010028")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:おもしろいわけじゃないけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010029")

	change_face(Actor002,"Smile")

	--★★トリスタン★★:不思議とつまらないわけでもない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010030")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★トリスタン★★:もうちょっと監視は続けさせてもらうけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:身構えなくてもいいよ、これからは
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010032")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ありがとう…なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010033")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺だって驚いてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010035")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:トリスタンは俺に対して攻撃的ともいえるくらい冷たいし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010036")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:変な言いかたしないでくれる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010037")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボクは自分の仕事は責任もってやるタチなんだ私情なんていっさい挟まずにね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010038")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうかあ？だいぶ私情が入ってた気がするけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:たとえば？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010040")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:私情抜きであそこまで毒舌を吐けるとは思えない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010041")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0020")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:毒舌？キミに対してだけ喋りかたを変えていたつもりはないけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010042")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（そういえば毒舌はいつものことなんだった…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101014_00010043")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:綺麗な場所だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いい眺めで、風も気持ちよくて…静かだけど明るい雰囲気でいいところだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010047")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:建築物の様式もログレスとはまた違ってて新鮮だし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010048")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:コーンウォールは、ログレスとはまた少し違う文化を持っているからね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010049")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:この先を少し行ったら<br>野外劇場なんかもあるよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:見に行ってみる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_00010051")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:面白そうだな！連れて行ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_00010052")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"トリスタン")
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
	load_area_scene_preload(114021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
