-- このluaスクリプトは、MA_01104_41.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera006 = SetTemplate("Actor006",270,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera007 = SetTemplate("Actor007",270,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera008 = SetTemplate("Actor008",90,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera009 = SetTemplate("Actor009",90,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
off_active(Actor006) -- トリスタン非表示
off_active(Actor007) -- イゾルデ非表示
off_active(Actor008) -- ギネヴィア非表示
off_active(Actor009) -- ギネマウア非表示
set_pos(Actor006, {2.423, 0, -13.397})
set_pos(Actor007, {3.272, 0, -13.321})
set_pos(Actor008, {-2.544, 0, -13.321})
set_pos(Actor009, {-3.493, 0, -13.295})
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:…おいしい
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_410002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ディナタン★★:おいしいんですよ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410003")

	PlayAction(Actor004,"to  Std_Joy")
	change_face(Actor004,"Smile")

	--★★ガレス★★:美味しい！？<br>やったー、嬉しいぞ！！
	Talk(Actor004,"NPCNAME_0072","speech","L","MA_01104_410005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガレス★★:アッ<br>いきなりゴメンな♪
	Talk(Actor004,"NPCNAME_0072","speech","L","MA_01104_410007")

	change_face(Actor003,"Surprise")

	--★★ディナタン★★:いっ、いえ！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01104_410009","MA_01104_410010","MA_01104_410011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そんなにおいしいんだったら<br>おかわりするか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_410013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:そうですね<br>せっかくですし同じものをもう一皿…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_410014")

	PlayAction(Actor003,"to Sit01_RH01")
	change_face(Actor003,"Normal")

	--★★ディナタン★★:すいませーん！<br>おかわりをくださーい！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ディナタンのぶんも食べる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_410017")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:な、なんで私の！？<br>あげるなら兄さんのを…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410018")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:いえ、マスターのものを無理にいただくわけには
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_410019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺のぶんも食べる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_410021")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:そ、そんな！<br>マスターのぶんまで御馳走になるなど
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_410022")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…あの、でも<br>本当に良いのですか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_410023")

	goto Block1end

::Block1end::
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:なにを食べても、おいしいんです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_410025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ディナタン★★:おいしいよね
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410026")


	--★★ディナタン★★:私も最近はすっごく
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…俺もだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_410029")

	PlayAction(Actor004,"to  Std_Joy")
	change_face(Actor004,"Smile")

	--★★ガレス★★:すごい良い人たちだ…！<br>やる気出て来た…！！
	Talk(Actor004,"NPCNAME_0072","speech","L","MA_01104_410031")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★リオネス★★:コック長！<br>妥協なき料理と配膳の勝利だな！！
	Talk(Actor005,"NPCNAME_0073","speech","L","MA_01104_410033")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ガレス★★:皆っ！五月祭は楽しみにしててくれ！<br>食卓がとんでもなくスゴ～イことになるからな♪
	Talk(Actor004,"NPCNAME_0072","speech","L","MA_01104_410034")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
off_active(Actor004) -- ガレス非表示
off_active(Actor005) -- リオネス非表示
setup_small_camera_end()
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…五月祭－－…？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_410035")

-- ▼直接出力
DontChangeRandomCamera(true)
on_camera(Camera003)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:その年の豊穣を願う<br>お祭りだったはずだけど…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410036")

-- ▼直接出力
DontChangeRandomCamera(false)
setup_small_camera_start()
on_active(Actor006) -- トリスタン表示
on_active(Actor007) -- イゾルデ表示
PlayActionDirect(Actor006,"to Wlk")
PlayActionDirect(Actor007,"to Wlk")
slidemove(Actor006, 0.485, 0, -13.397 ,2.0)
slidemove(Actor007, 1.334, 0, -13.321 ,2.0)
wait_time(2.0)
PlayActionDirect(Actor006,"to Std_Loop")
PlayActionDirect(Actor007,"to Std_Loop")
turn(Actor006,0, -6, 0,0.3)
turn(Actor007,0, 0, 0,0.3)
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",0.5)
set_enable_auto_lookat(Actor003,false)
lookat_weight(Actor003,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor003,Actor006,"J_Head",0.5)
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor001,Actor006,"J_Head",0.5)
-- ▲直接出力

	--★★トリスタン★★:外堀から埋めるのはイイ策だね<br>まずはコックから？
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410038")


	--★★イゾルデ★★:輝かしい学園生活のための<br>転校生による生存戦略じゃないかしら
	Talk(Actor007,"NPCNAME_0075","speech","L","MA_01104_410040")

	open_select_window_tag(Actor001,"Normal","MA_01104_410041","MA_01104_410042")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:席、空いてるけど？<br>一緒に食べるなら…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_410044")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
lookat_weight(Actor006,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor006,Actor001,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★トリスタン★★:あいにく<br>ランチは済ませたばかりなんだ
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410045")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★イゾルデ★★:その気持ちだけ<br>いただいておくわ
	Talk(Actor007,"NPCNAME_0075","speech","L","MA_01104_410046")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…食べ始めたばかりなんだ<br>悪いが向こうへ行ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_410048")

-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
lookat_weight(Actor006,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor006,Actor001,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:に、兄さん！<br>もう少し言葉を選んでよ！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410049")

	change_face(Actor006,"Normal")

	--★★トリスタン★★:なんでキミが指図するんだい？
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★トリスタン★★:ま、安心してよ<br>別に長居するつもりはないから
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410051")

	goto Block2end

::Block2end::
	change_face(Actor006,"Normal")

	--★★トリスタン★★:五月祭のことを話してたよね<br>大恥かいて欲しくてさ
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410053")

	change_face(Actor003,"Surprise")

	--★★ディナタン★★:大恥？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410054")

	PlayAction(Actor006,"to  Std_Talk")

	--★★トリスタン★★:ログレスの…というか<br>うちの学園の五月祭はちょっと変わっていてね
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410055")

	change_face(Actor007,"Normal")

	--★★イゾルデ★★:男子生徒たちの投票で<br>その年の『五月女王』を選ぶの
	Talk(Actor007,"NPCNAME_0075","speech","L","MA_01104_410056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:判断基準はひとそれぞれ<br>センス、ファッション、ルックス、とか？
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410057")


	--★★トリスタン★★:それに選ばれたら大変なんだ
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410058")


	--★★トリスタン★★:誘拐を申し込まれるんだよ<br>五月女王様は、男子生徒たちから
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410059")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:誘拐されてしまったら…<br>どうなるのでしょうか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_410060")

-- ▼直接出力
set_enable_auto_lookat(Actor006,true)
lookat_delay_weight_reset(Actor006,0.6)
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★トリスタン★★:ふふ。どうなるんだろうね？<br>見知らぬ男女の仲を詮索する趣味はないから
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410061")

-- ▼直接出力
on_active(Actor008) -- ギネヴィア表示
on_active(Actor009) -- ギネマウア表示
PlayActionDirect(Actor008,"to Wlk")
PlayActionDirect(Actor009,"to Wlk")
slidemove(Actor008, -0.273, 0, -13.321 ,1.4)
slidemove(Actor009, -1.222, 0, -13.295 ,1.4)
setup_small_camera_start()
wait_time(1.4)
PlayActionDirect(Actor008,"to Std_Loop")
PlayActionDirect(Actor009,"to Std_Loop")
turn(Actor008,0, 0, 0,0.3)
turn(Actor009,0, 0, 0,0.3)
-- ▲直接出力

	--★★ギネヴィア★★:そう！だからねノワール？
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01104_410063")

	PlayAction(Actor008,"to Greet_one")
	change_face(Actor008,"Smile")

	--★★ギネヴィア★★:五月祭当日は<br>しっかりわたしを護衛なさい！！
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01104_410064")

	open_select_window_tag(Actor001,"Normal","MA_01104_410065","MA_01104_410066")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？<br>…なんで？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_410068")

	PlayAction(Actor008,"to  Std_Angry")
	change_face(Actor008,"Surprise")

	--★★ギネヴィア★★:あっきれた！<br>わかるでしょ、フツー？
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01104_410069")

	change_face(Actor008,"Smile")

	--★★ギネヴィア★★:わたしが五月女王に選ばれて<br>みんながわたしを誘拐にくるからよ！
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01104_410070")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:わかってるよ<br>キミが五月女王に選ばれるから－－
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_410072")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Surprise")

	--★★ギネヴィア★★:そう！誘拐に来た生徒たちから護衛を…って<br>わ、わたしが選ばれると思ってくれてるの…？
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01104_410073")

	PlayAction(Actor008,"to  Std_Joy")
	change_face(Actor008,"Smile")

	--★★ギネヴィア★★:や、やだーもう！<br>ノワールったら素直―！！
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01104_410074")

	goto Block3end

::Block3end::
-- ▼直接出力
se_play("SE_ADV_MA_01C109_01_Bell")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ギネヴィア★★:五月祭の栄光をもって<br>わたしは故郷に凱旋するのよ！！
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01104_410076")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ギネマウア★★:………ご期待申し上げております、殿下
	Talk(Actor009,"NPCNAME_0070","speech","L","MA_01104_410078")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★トリスタン★★:キミも頑張りなよ<br>ディナタン…だっけ？
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410079")


	--★★ディナタン★★:へっ！？わ、たしですか…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410080")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:キミが誘拐されたら<br>きっとお兄さんは大騒ぎだ
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410081")


	--★★トリスタン★★:美しすぎる女王様を手中にすべく<br>群れなし現れる無頼漢
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410082")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Smile")

	--★★トリスタン★★:お兄さんは猛り、学園中の男子生徒をボコボコ！<br>めでたく退学なんて流れはどう？
	Talk(Actor006,"NPCNAME_0074","speech","L","MA_01104_410083")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008,false)
lookat_weight(Actor008,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor008,Actor006,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ギネヴィア★★:…ねえトリスタン？<br>どういうつもり？
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01104_410084")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…？<br>トリスタン－－…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_410085")

-- ▼直接出力
--トリスタン,CHRNAME_TRISTAN @名前変更
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★トリスタン★★:ああそうだ。言い忘れてたよ<br>儀式の成功おめでとう、ディナタン
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01104_410086")

-- ▼直接出力
OpenFirstAppearance(Actor006)
-- ▲直接出力

	--★★ディナタン★★:！？<br>どうして、それを…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_410087")


	--★★トリスタン★★:そろそろ授業が始るね<br>行こう、イゾルデ
	Talk(Actor006,"CHRNAME_TRISTAN","speech","L","MA_01104_410088")

-- ▼直接出力
--イゾルデ,CHRNAME_ISOLDE @名前変更
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★イゾルデ★★:ええ。サボるわけには、いかないものね
	Talk(Actor007,"CHRNAME_ISOLDE","speech","L","MA_01104_410089")

-- ▼直接出力
OpenFirstAppearance(Actor007)
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
