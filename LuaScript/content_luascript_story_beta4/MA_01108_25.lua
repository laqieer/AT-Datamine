-- このluaスクリプトは、MA_01108_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
load_image("10301020", "content_still_10301020_image", "103010200_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("10301021", "content_still_10301021_image", "103010210_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("10301022", "content_still_10301022_image", "103010220_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("10301023", "content_still_10301023_image", "103010230_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("10301024", "content_still_10301024_image", "103010240_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115157)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_TextOnly()
	Actor006 = InitializeCharacter_TextOnly()
	Actor007 = InitializeCharacter_TextOnly()
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ティルフィング★★:こんばんは、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250002")


	--★★ノワール★★:…ティルフィング
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250003")


	--★★ティルフィング★★:眠れませんか
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250004")

	open_select_window_tag(Actor001,"Normal","MA_01108_250006","MA_01108_250007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん、さすがにね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250009")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:生まれ故郷への帰還となれば<br>無理もありませんね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250010")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それ以外にも<br>今回の遠征、なにか胸騒ぎがするんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250011")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:…それは恐らく正しい不安です。マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250012")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…ですが同時に<br>かすかな希望でもあります
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:キミのほうこそ<br>休まなくていいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250015")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:私はマスターの武器です<br>それだけの身です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:…ですが、マスターのお心遣い<br>嬉しく思います
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250017")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:お伝えしたいことがあるのです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250019")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:なに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250020")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ティルフィング★★:…これより来たるは決断の刻
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:本当の武器を選び取る刻
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250022")


	--★★ノワール★★:まさか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250023")


	--★★テロップ★★:「継承者は<br>ゲシュタルト・シフトに至らんとしています」
	Talk(Actor008,"","narration","L","MA_01108_250024")


	--★★テロップ★★:「しかしそれはあまりにも理不尽な運命<br>喪失の確定した成果がもたらされます」
	Talk(Actor008,"","narration","L","MA_01108_250026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ティルフィング★★:ご自身の使命<br>恨みはしませんか
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250027")

	open_select_window_tag(Actor001,"Normal","MA_01108_250029","MA_01108_250030")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:…正直、どうして俺がと<br>恨んだことはあるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250032")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:アナタにはこれからも<br>忘れ得ぬ悲しみが増え続けます
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:けど<br>良い思い出も遺してこられた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250034")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:キミのおかげだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250035")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…いいえ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250036")

	change_face(Actor002,"Smile")

	--★★ティルフィング★★:…マスターが戦い続けた結果、です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250038")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:正直、走りつづけることに精一杯だったからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、これだけは言える
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250041")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:キミがいてくれたから<br>俺は今日まで走り続けることができたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250042")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:マスター、ありがとうございます<br>ですが…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250043")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:私ができたのは知りうる知識の一部を述べただけ<br>『本当』のことはほとんど伝えられていません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250044")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:アナタはご自身の力で走り<br>辿り着こうとしているのです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250045")

	goto Block2end

::Block2end::
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:私の役目は継承者を導くことのみ<br>この時代に深く関わることは許されていません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250047")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:すべてはアナタの手で勝ち取った戦果です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250049")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…キミが俺を継承者として<br>GSへと導いてくれてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:俺がその務めを果たしたとき<br>キミはどうなる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250051")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:誇らしく思います<br>とても
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250053")


	--★★ノワール★★:…それがキミの願いなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250054")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301020", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力

	--★★ギネヴィア★★:…う、うううーっ
	Talk(Actor003,"CHRNAME_GUINEVERE","simple","N","MA_01108_250056")


	--★★ギネヴィア★★:ううあああぁぁあぁああぁあああぁ――…
	Talk(Actor003,"CHRNAME_GUINEVERE","simple","N","MA_01108_250057")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("10301021", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★マルディサント★★:ディ、ナタン…、せんせ…、いやだ…<br>大事な人、持ってかれる…もういやだああ…！
	Talk(Actor004,"CHRNAME_MALADISANT","simple","N","MA_01108_250059")


	--★★ディナタン★★:ご、めん、ね…マァル
	Talk(Actor005,"CHRNAME_DINATAN","simple","N","MA_01108_250060")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("10301022", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ランスロット★★:師匠は…ライエンス率いるカレドニアの軍勢を<br>単身で幾度も食い止め…
	Talk(Actor006,"CHRNAME_LANCELOT","simple","N","MA_01108_250062")


	--★★ランスロット★★:俺が見つけた頃にはもう<br>ボロボロに、衰えて…
	Talk(Actor006,"CHRNAME_LANCELOT","simple","N","MA_01108_250063")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
--エフェクト終了
hide_image()
 
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力

	--★★ノワール★★:バルバロイに苦しめられる人々のためにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250065")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301023", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力

	--★★ノワール★★:…………どこに、いったんだ、みんな
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_250067")


	--★★ノワール★★:さがすんだ、まだどこかに…！<br>約束したんだ、見つけるんだ…！！
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_250068")


	--★★ノワール★★:こんな現実、信じてたまるか──…！！
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_250069")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301024", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ティルフィング_2★★:@－－終わりの続きを斬り拓く、武器を
	Talk(Actor007,"CHRNAME_NAMELES","simple","N","MA_01108_250071")


	--★★ノワール★★:武器を――寄越せ
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01108_250072")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
--エフェクト終了
hide_image()
 
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:継承者として戦わせてくれ<br>一緒に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_250074")


	--★★ティルフィング★★:…はい<br>マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_250076")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10301020", "content_still_10301020_image", "103010200_StillImage")
load_image_preload("10301021", "content_still_10301021_image", "103010210_StillImage")
load_image_preload("10301022", "content_still_10301022_image", "103010220_StillImage")
load_image_preload("10301023", "content_still_10301023_image", "103010230_StillImage")
load_image_preload("10301024", "content_still_10301024_image", "103010240_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115157)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
