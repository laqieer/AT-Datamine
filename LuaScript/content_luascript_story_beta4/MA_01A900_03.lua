-- このluaスクリプトは、MA_01A900_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114041_01","114041_01_h")
Include("content_adv_advsmall_114041_01","Template114041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",80,CharaPos114041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114041_01,CameraPos114041_01_003)
	Camera002 = SetTemplate("Actor002",1.5,CharaPos114041_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114041_01,CameraPos114041_01_004)
	InitializeTemplateRandomCamera114041_01()
	InitializeTemplate114041_01()
-- ▼直接出力
 load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("10103020", "content_still_10103020_image", "101030200_StillImage")
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,-0.52, 0.6, -16.5)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",1.0)
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114041)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:なつかしい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ギネヴィアが教えてくれたんだよな<br>ＧＳのこと、カリバーンのこと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat_all(true)
set_common_look_at(Actor002,Actor001)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.5)
wait_time(0.5)
set_common_look_at(Actor001,Actor002)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:なかば無理矢理連れ出してね<br>楽しかった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030005")

	change_face(Actor001,"Smile")

	--★★ノワール★★:雇わせろって<br>異国のコインを渡された
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_030006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:貴重なコレクションなのよ？<br>感謝なさい。なお返品は受け付けません
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030007")


	--★★ノワール★★:返さないよ<br>いつか外国に行ったときに使うんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_030008")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ひどい<br>とっておいてよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_030010")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:とっておいてよね、ずっと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_030013")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたし、封になるから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030014")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ティルフィングも近いことやってたんでしょ？<br>だぁいじょうぶ、できるできるヨユーよヨユー！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030015")


	--★★ギネヴィア★★:もし次に目覚めるとしたら遠い未来でしょ？<br>いわば時間旅行！贅沢なひとり旅じゃない？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030016")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:一千年後ってなにがあるのかなあ<br>どんな光景が広がってると思う？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★ギネヴィア★★:新天地でもだいじょぶよ！友達できるわ！<br>学習したの、友達づくりの方法！知りたい？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A900_030018")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A900_030020","MA_01A900_030021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:知りたいな、ぜひ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_030023")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:にっしっし…♪<br>素直でよろしいっ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030024")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ギネヴィアはこれまで<br>たくさん友達作って来たもんな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_030025")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうよ、あなたも近くで見てたでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺のほうが友達多いよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_030028")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:そこでマウント取るぅ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030029")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あなたが友達多いのは<br>学園中みーんな知ってるよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030030")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:友達作りの秘訣とは！<br>『飾らないでお話すること』
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030032")


	--★★ギネヴィア★★:でねでね、旅先で友達作るでしょお？<br>で！ずっとこっちにいたいなあとか思うわけ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:でも旅だからね、帰らなきゃ！ってなって<br>異国の友達とは「また連絡するね」なんて言って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030035")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:それでそれで、旅が終わったら<br>…家に、家に、家に、帰って来て、言うの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030036")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:「やっぱり家が一番ね」…ってえぇ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:お土産話するの「羨ましい？」とか自慢げに<br>「あなたにも見せたかったなあ」とか得意げに
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030039")


	--★★ギネヴィア★★:それで約束するの<br>「今度は」「一緒に」…「行こうね」って…っ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030040")

-- ▼直接出力
CloseTalkWindow()
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,18,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(2.0)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:………や、だ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030042")

-- ▼直接出力
CloseTalkWindow() 
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
show_image("10103020", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
keep_turn_lookat(Actor002,Actor001,1)
-- ▲直接出力

	--★★ギネヴィア★★:やだ、やだあああああぁぁぁああ<br>こわいよノワールううぅぅぅ…！！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030043")


	--★★ギネヴィア★★:ひとり、ぼっちで、あなたもいない<br>おねえちゃんもいない、だれもいない…！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030044")


	--★★ギネヴィア★★:しかも聖遺物化しちゃったら<br>この世界で誰も<ruby=ギネヴィア>わたし</ruby>を覚えてない…！！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030045")


	--★★ギネヴィア★★:それでもやらなきゃって覚悟して…！<br>でもわたし、どうしてこんなにいつもだめなの？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030047")

	open_select_window_tag(Actor001,"Normal","MA_01A900_030049","MA_01A900_030050")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()

	--★★ノワール★★:…俺が覚えてるよ
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01A900_030052")


	--★★ギネヴィア★★:ずっと、わたしを忘れさせたって思いながら<br>生きていくの、あなたがつらいよ…！！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030053")


	--★★ギネヴィア★★:でも<br>忘れてほしくもないの…！！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030055")

	goto Block2end

::Block2_2::
	CloseTalkWindow()

	--★★ノワール★★:みんなも忘れないよ<br>キミのこと
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01A900_030057")


	--★★ギネヴィア★★:ウソ言わないでよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030058")


	--★★ギネヴィア★★:あなたは見てきたんじゃないの！？<br>聖遺物化していった人たちのこと！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030059")


	--★★ギネヴィア★★:ランスロットのキラーズは！？！？<br>どこいったのよ！！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030060")

	goto Block2end

::Block2end::

	--★★ギネヴィア★★:キラーズになんかならなければ…！<br>こんな気持ちに、ならなかったのに…！！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030062")


	--★★ギネヴィア★★:そんなこと考える自分もいや…！<br>無理だし、わがままだけど、どうしても…っ
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030063")


	--★★ギネヴィア★★:ばか、ばか、ばかああああ、ふざけんなああああ<br>なにが、なにがＧＳよ、なにがキラーズよ…！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030065")


	--★★ギネヴィア★★:あなたのとなりにいたい！！<br>このきもちも、あなたとのおもいでも──
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030067")


	--★★ギネヴィア★★:けしたくな、い…っ
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030068")

-- ▼直接出力
CloseTalkWindow() 
wait_time(0.5)
fadeout(0,0,0,1.0,0.5)
wait_time(0.5)
se_play("SE_ADV_MA_01104_25_Fall")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
fadein(0.5)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:！？ギネヴィア…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_030070")

	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:の、わー、る…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030071")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:なんだ、ろ…<br>わたし…、やだな…このまま…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030073")


	--★★ギネヴィア★★:さよならも、いえないで…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_030075")

-- ▼直接出力
CloseTalkWindow() 
wait_time(1.0)
-- ▲直接出力

	--★★ギネヴィア★★:………どうして、わたしをえらんだの
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_030076")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
 load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("10103020", "content_still_10103020_image", "101030200_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114041)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
