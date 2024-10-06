-- このluaスクリプトは、MA_01105_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_004)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor007")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:わざわざお断りを入れに来たのよ<br>アーサーに会わせて
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150002")


	--★★知将ケイ★★:王は五月祭の後処理と<br>キャメリアード侵攻にむけた兵の編成準備中だ
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150003")


	--★★ギネヴィア★★:わたしが<br>その先遣隊をやったげるって言いに来たのよ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150004")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★知将ケイ★★:焦燥に駆られてはなりません、殿下
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150006")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:わたし、じゅうぶん待ったでしょ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150007")


	--★★知将ケイ★★:カレドニアの軍勢は<br>その版図を拡げ続けている
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150008")


	--★★知将ケイ★★:きゃつらに制圧されたキャメリアードに<br>取り残された王族たちの安否もわからぬまま…
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:生きてる、絶対生きてる
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150011")

-- ▼直接出力
set_common_look_at(Actor007,Actor003)
change_face(Actor007,"Sad")
-- ▲直接出力

	--★★知将ケイ★★:捕虜の交渉に送った者も帰らぬ<br>対話手段はない、敵情も全く見えてこない
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150013")


	--★★知将ケイ★★:これまではきゃつらが攻めてくることはなく<br>戦況は膠着していたのだが…
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150014")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★知将ケイ★★:ノワール、貴公がカリバーンを抜いて以来
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150015")


	--★★知将ケイ★★:キャメリアード方面で<br>バルバロイの動きが活発化してきている
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01105_150018","MA_01105_150019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺が封を解いたから…<br>ティルフィングを抜いたから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_150021")

	change_face(Actor001,"Sad")

	--★★ノワール★★:バルバロイが活発になり始めていると…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_150022")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★知将ケイ★★:そう考えることもできる<br>ヤブヘビだったかも…と言ったまでだ
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…偶然じゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_150025")

	change_face(Actor005,"Normal")

	--★★知将ケイ★★:偶然にしては時期が合い過ぎている
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150026")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★知将ケイ★★:看過するわけにはいかんのだよ<br>私の立場上な
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150027")

	goto Block1end

::Block1end::

	--★★ギネヴィア★★:「原初の劔を継ぐ者待てば<br>いずれカリバーンは抜き放たれん」
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150029")


	--★★ギネヴィア★★:「最初の武器を携えて<br>終わりの続きを往く」
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150030")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:恐らく、増え始めたバルバロイがもたらす<br>終わりを回避して続きをつくるために──
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150031")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力

	--★★ギネヴィア★★:あの剣は抜かれるべくして抜かれたのよ<br>バルバロイが増え始めたから使う時が来ただけ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150033")

	open_cutin(1,1)
	on_cutin(1,Actor004,"Normal")

	--★★アーサー★★:今は多くの円卓の騎士たちが遠征中の状況だ<br>バルバロイへの反抗には万全を期したいんだよ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01105_150034")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
EntryWalk_2P(Actor002,Camera002,EntryData110021_01_07,CameraAssetBundleName110021_01,CameraPos110021_01_107,Actor004,CharaPos110021_01_006,CharaPos110021_01_106)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:キャメリアードとログレスは目と鼻の先<br>焦って均衡を崩せば敵は一気にここへなだれ込む
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150036")

	open_cutin(1,1)
	on_cutin(1,Actor003,"Anger")

	--★★ギネヴィア★★:だから逸って下手は打てない<br>そういうことでしょ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","N","MA_01105_150038")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★知将ケイ★★:………左様ですな
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150040")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:わかってるわそんなこと<br>だとすればランスロット──
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150041")


	--★★ギネヴィア★★:最強騎士が持つ<br>最強のキラーズはいま何処に？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150043")

-- ▼直接出力
wait_time(0.5)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:…なにを仰せになりたいんです、殿下
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_150045")

-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor006)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")

	--★★ギネヴィア★★:出し惜しまないで欲しいなってハナシ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150046")


	--★★マーリン★★:乙女を待たせ過ぎですよ。主様？
	Talk(Actor006,"CHRNAME_NAMELES","speech","N","MA_01105_150048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Bow")
-- ▲直接出力

	--★★マーリン★★:ノワール様…お初にお目にかかります<br>宮廷魔術師兼、アーサー様のお目付け役
	Talk(Actor006,"CHRNAME_NAMELES","speech","L","MA_01105_150050")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor006)
DontChangeRandomCamera(true)
--マーリン,CHRNAME_MERLIN @名前変更
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor005,-211,0)
-- ▲直接出力

	--★★マーリン★★:マーリンと申します
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01105_150051")

-- ▼直接出力
OpenFirstAppearance(Actor006)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★知将ケイ★★:マーリン様…！<br>貴方が出られずとも──
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_No")

	--★★マーリン★★:類まれなる大出世をされた円卓の騎士様に<br>無礼はなりませんよ。ケイ卿
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01105_150053")

	change_face(Actor006,"Smile")

	--★★マーリン★★:そして、婚約者様の無茶に応えて差し上げるのは<br>貴方の務め…ですよね。アーサー様
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01105_150055")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:ギネヴィア、待たせてしまって済まなかった<br>マーリンの同行を取り付けた
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01105_150057")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Sad")

	--★★知将ケイ★★:アーサー、貴公はまた…！
	Talk(Actor005,"CHRNAME_KAY","speech","L","MA_01105_150058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:…！？じゃあ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150059")

	PlayAction(Actor004,"to  Std_Talk")

	--★★アーサー★★:先遣隊の出立はX日後でどうだ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01105_150060")

	change_face(Actor004,"Smile")

	--★★アーサー★★:お義父さまによろしくな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01105_150062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:………別居中ですって伝えるわ<br>包み隠さず
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_150064")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor007")
MobsNo = 0
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
