-- このluaスクリプトは、MA_01A111_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_12","111013_12_h")
Include("content_adv_advsmall_111013_12","Template111013_12_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_12_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_MA01A111_04_Controller","to Std_Loop",CameraAssetBundleName111013_12,CameraPos111013_12_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_12_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_MA01A111_04_Controller","to Std_Loop",CameraAssetBundleName111013_12,CameraPos111013_12_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_12_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_MA01A111_04_Controller","to Std_Loop",CameraAssetBundleName111013_12,CameraPos111013_12_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_12_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_MA01A111_04_Controller","to Std_Loop",CameraAssetBundleName111013_12,CameraPos111013_12_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111013_12_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_12,CameraPos111013_12_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111013_12_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_12,CameraPos111013_12_003)
	InitializeTemplateRandomCamera111013_12()
	InitializeTemplate111013_12()
-- ▼直接出力
Hide(Actor005)
Hide(Actor006)
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
SkipDefaultMotion(Actor002)
SkipDefaultMotion(Actor001)
SkipDefaultMotion(Actor003)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor001,"to Sit01_Loop")
PlayActionDirect(Actor002,"to Sit01_Loop")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
CUT_10 =  cat_template_camera("P10_Cam")
CUT_11 =  cat_template_camera("P11_Cam")
CUT_12 =  cat_template_camera("P12_Cam")
CUT_13 =  cat_template_camera("P13_Cam")
CUT_14 =  cat_template_camera("P14_Cam")
CUT_15 =  cat_template_camera("P15_Cam")
CUT_16 =  cat_template_camera("P16_Cam")
CUT_17 =  cat_template_camera("P17_Cam")
CUT_18 =  cat_template_camera("P18_Cam")
CUT_19 =  cat_template_camera("P19_Cam")
CUT_20 =  cat_template_camera("P20_Cam")
CUT_21 =  cat_template_camera("P21_Cam")
-- ▲直接出力
-- ▼直接出力
RndCamera001=CUT_10
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101044","001","101044001","content_animationpack__common","FacialPack","Actor006")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ローラ★★:傷が縫えたら、いいのにね
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_11)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フレン★★:…ごめんね、ローラ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040003")

	change_face(Actor002,"Normal")

	--★★ローラ★★:服を、ね…作ってたんだよ<br>お姉ちゃん
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040004")

	change_face(Actor002,"Smile")

	--★★ローラ★★:お姉ちゃん、と…お揃い<br>あはっ。双子コーデ…したいんだあ…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040005")

	change_face(Actor001,"Normal")

	--★★フレン★★:…戦いが終わればいつだって行けるから<br>すぐに帰れるから…ローラ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040006")

	change_face(Actor002,"Sad")

	--★★ローラ★★:………あれっ<br>私たち、どこに帰ればいいんだっけ
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040007")


	--★★フレン★★:ローラ…？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040008")


	--★★ローラ★★:家は…どこにあるんだっけ<br>いつから、どうして、戦ってるんだっけ
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040009")

	change_face(Actor001,"Surprise")

	--★★フレン★★:どう、したの、ローラ…？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040010")

	change_face(Actor005,"Smile")

	--★★モーロノエー★★:皇太子殿下も節操がないわよね
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01A111_040012")

	change_face(Actor006,"Smile")

	--★★グリーテン★★:バルバロイにしたり、キラーズにしたり<br>手当たり次第、目につき次第…♪
	Talk(Actor006,"CHRNAME_NAMELES","speech","N","MA_01A111_040014")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor005)
Appear(Actor006)
wait_time(0.3)
setup_small_camera_start(CUT_12)
wait_time(0.3)
PlayActionDirect(Actor001,"Sit02_Start")
wait_time(1.8)
--モーロノエー,CHRNAME_SISTERS_1 @名前変更
--グリーテン,CHRNAME_SISTERS_3 @名前変更
-- ▲直接出力

	--★★モーロノエー★★:まるで<br>愛を試しているみたい
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","R","MA_01A111_040016")

	change_face(Actor001,"Normal")

	--★★フレン★★:どういうこと…
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040017")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_13)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★モーロノエー★★:頑丈な玩具があったとして<br>一番気になるコトって何かしら
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","R","MA_01A111_040018")

	change_face(Actor006,"Normal")

	--★★グリーテン★★:どうしたら壊れるか<br>試してみたくなるでしょ？
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","R","MA_01A111_040019")

	change_face(Actor001,"Surprise")

	--★★フレン★★:…！
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040020")


	--★★モーロノエー★★:ルーシャス様はあらゆる面からあなたたちを試す<br><ruby=ゲシュタルト・シフト>ＧＳ</ruby>の力、その強さ、その心…
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","R","MA_01A111_040021")


	--★★グリーテン★★:ローラは望んで試されたの
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","R","MA_01A111_040023")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_14)
wait_time(0.3)
-- ▲直接出力

	--★★ローラ★★:…ひどい、です<br>ひみつにしようと…思ってたのに
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040024")

	change_face(Actor005,"Smile")

	--★★モーロノエー★★:目立たぬ努力、ご苦労様♪
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","R","MA_01A111_040025")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_15)
wait_time(0.3)
PlayActionDirect(Actor001,"to Sit01_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ローラ★★:お姉ちゃんを守るの…<br>私は、そのために、来たんだよ…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040026")


	--★★ローラ★★:ルーシャス様が試そうとしていること<br>全部、私がしてもらうの…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040027")


	--★★ローラ★★:…そうしたら、ルーシャス様<br>お姉ちゃんには、きっと優しくしてくれる…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040028")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_11)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フレン★★:私なんかのために………そんな
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040029")


	--★★ローラ★★:お姉ちゃんが私を愛してくれたから<br>私も出来ることをするの…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A111_040030")


	--★★グリーテン★★:もう彼女は長くないね<br>だけどひとつだけ、長らえる方法もある
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","R","MA_01A111_040031")

-- ▼直接出力
PlayActionDirect(Actor001,"Sit02_Start")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フレン★★:方法って…、なに…！？<br>ローラは助かるの…？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040032")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_16)
wait_time(0.3)
-- ▲直接出力

	--★★グリーテン★★:ネアのヤることは中途半端ね<br>オマエの因子量ならもっと強くなれるのに
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","R","MA_01A111_040033")


	--★★グリーテン★★:ワタシならその方法を教えてあげられるわ
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","R","MA_01A111_040034")

-- ▼直接出力
Appear(Actor004)
Appear(Actor003)
-- ▲直接出力

	--★★グリーテン★★:大切なものを守るには力がいるでしょ<br>もっともーっと、ね
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","R","MA_01A111_040035")

	change_face(Actor003,"Anger")

	--★★ラシア★★:お待ちを
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01A111_040037")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_17)
PlayActionDirect(Actor001,"to Sit01_Loop")
PlayActionDirect(Actor004,"std02_Start")
PlayActionDirect(Actor003,"std02_Start")
wait_time(0.3)
-- ▲直接出力

	--★★グリーテン★★:あっ、図体だけの将軍と<br>臆病者で役立たずのおふたり
	Talk(Actor006,"CHRNAME_SISTERS_3","speech","R","MA_01A111_040038")


	--★★ヴェルナルス大将軍★★:…返す言葉もないな
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01A111_040039")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_18)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラシア★★:バルバロイに身を委ねるは不可逆な行為…<br>ローラが、これではあまりにも…！
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01A111_040040")

-- ▼直接出力
PlayActionDirect(Actor001,"Sit03_Start")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フレン★★:口挟まないで…！！
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040041")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_19)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラシア★★:…フレン
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01A111_040042")


	--★★フレン★★:傷も塞げない、弱ってくだけ…<br>無念も晴らせないままで…
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040044")


	--★★フレン★★:どうして君が無事で、ローラがこんな…！<br>ラシア、どうしてくれるのよ、ねえ、ねえ！
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A111_040045")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
Hide(Actor003)
setup_small_camera_start(CUT_13)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★モーロノエー★★:なにかしてあげられる？<br>死を待つだけの彼女に
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","R","MA_01A111_040046")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,0.2)
wait_time(0.2)
Appear(Actor003)
wait_time(0.2)
setup_small_camera_start(CUT_17)
fadein(0.2)
wait_time(0.3)
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:…
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01A111_040048")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor003,"std02_end")
wait_time(1.30)
fadeout(0,0,0,1.0,0.2)
wait_time(0.3)
setup_small_camera_start(CUT_20)
set_pos(Actor003,{CharaPos111013_12_006[1],CharaPos111013_12_006[2],CharaPos111013_12_006[3]})
turn_chara(Actor003,CharaPos111013_12_006[4],0)
wait_time(0.2)
fadein(0.2)
PlayActionDirect(Actor003,"Sit01_Start")
SkipDefaultMotion(Actor003)
wait_time(3.6)
fadeout(0,0,0,1.0,0.2)
wait_time(0.3)
setup_small_camera_start(CUT_21)
Hide(Actor001)
Hide(Actor002)
fadein(0.2)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラシア★★:私が、勝利を
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01A111_040050")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101044","001","101044001","content_animationpack__common","FacialPack","Actor006")
	system.PreLoadRequest(CameraAssetBundleName111013_12)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
