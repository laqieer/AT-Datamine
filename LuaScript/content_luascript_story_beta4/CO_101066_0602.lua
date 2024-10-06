-- このluaスクリプトは、CO_101066_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:今日は<br>どんな研究を手伝えばいいんだ？<br>
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力

	--★★ブレイズ★★:うーむ。今日はこのあいだの<br>戦闘データをまとめようと思っとるんじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:いやあ、たっぷりデータが取れたから<br>研究がさらに捗ってしまうわい～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020004")

	change_face(Actor001,"Sad")

	--★★ノワール★★:このあいだ…本当にすごかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020005")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:んん？すごいって、なにがじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020006")

	open_select_window_tag(Actor001,"Normal","CO_101066_06020008","CO_101066_06020009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたの魔法がだよ<br>あんなにたくさんの魔物を一瞬で片付けるなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ああ～、あれか<br>あれくらい朝飯前のチョチョイのチョイじゃよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020012")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんなレベルじゃなかったと思うけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたの興奮ぶりがだよ<br>魔物が近づいてもしばらく気づかないし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:いやあ、バルバロイが目の前にいると思うと<br>ついそっちに目が釘付けになってしまってのう～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020016")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:一時はどうなるかと思ったよ<br>まぁ、魔物はあんたが全部倒しちまったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020017")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…あんたって本当に大魔法使いだったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020019")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0029")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:なんと！疑っとったんか！？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020020")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、だって…<br>普段は全然そんな感じじゃないし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020021")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:しかたない。ワシが大魔法使いだった頃の話を<br>おぬしに聞かせてやるとするかのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020022")


	--★★ブレイズ★★:きゃわいい女子に話すほうが楽しいんじゃが<br>まぁよい。あれはワシの髭が30cmだった頃…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020023")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力

	--★★ブレイズ★★:とある国で、ワシが仲間らと宿で休んでいると<br>突然、街に大量の魔物が入り込んできた
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020024")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:なんと、そやつらは国を乗っ取るために<br>城を奪おうとしておったのじゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ～、それでそれで？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:うむ。ワシは空から侵入する魔物をすべて<br>魔法で撃ち落としたんじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020027")


	--★★ブレイズ★★:そして敵将の魔物と一対一の真剣勝負<br>そこでワシの相棒の――
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020028")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:…あれ、なんじゃったっけ？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:ちょっ、いいところなのに！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020031")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0037")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:すまんすまん、ど忘れじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020032")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:それじゃドラゴン退治の話にしようかのう<br>あれはワシの髭に初めて枝毛が見つかった日…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020033")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★ブレイズ★★:ワシらが立ち寄った村には<br>大イノシシの被害が頻発しておったんじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020034")


	--★★ブレイズ★★:そやつは気まぐれに村を襲っては、<br>家畜や食べ物を奪い、人を傷つける
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:村人たちは皆困り果てておった<br>そこでワシらが退治に向かったんじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020037")


	--★★ブレイズ★★:大イノシシの全長は１０メートルをゆうに超え<br>牙は巨木よりも太く、皮膚は岩よりも硬かった
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020038")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:だがなんとかワシの魔法でやつの動きを封じ、<br>総攻撃して弱らせた。そしてトドメは――
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020039")

-- ▼直接出力
setup_small_camera_end(RndCamera008)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:トドメは、いったいどうやって！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020040")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:…はて、どうしたんじゃったっけ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0033")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ちょっと～！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020042")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力

	--★★ブレイズ★★:うーん…思い出せんのう<br>髭の調子が悪いからじゃろうか
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020043")

	change_face(Actor001,"Normal")

	--★★ノワール★★:全部いいところが抜けてるんだよなぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020044")


	--★★ブレイズ★★:………
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020045")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:…ブレイズ先生？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ブレイズ★★:…いや、なんでもない
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020047")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ま、思い出せんものはしかたないのう<br>それじゃ次の話――
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_06020048")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor002)
set_pos(Actor001,{-2.404,0,4.832})
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001, -0.646, 0, 3.817, 2)
wait_time(2)
PlayActionDirect(Actor001,"to Std_Loop")
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:や、やっと終わった…<br>いくつ武勇伝もってるんだ、あの人…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020050")


	--★★ノワール★★:調子に乗って相槌を打ちまくった<br>俺が悪かったのかな…反省しないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020052")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、ブレイズ先生の話<br>毎回肝心なところがボンヤリしてるんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020054")


	--★★ノワール★★:仲間の話になると<br>とたんに打ち切って次の話をしだすし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020055")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ひょっとして<br>仲間の話を、覚えてない………？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_06020057")

-- ▼直接出力
local trustParam = set_communication_rankup("ブレイズ_コミュランク", "ブレイズ_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
